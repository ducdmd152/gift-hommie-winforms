﻿using BusinessObjects;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DataAccessObjects
{
    public class UserDAO
    {
        // Singleton Pattern
        private UserDAO() { }
        private static UserDAO instance = null;
        private static readonly object instanceLock = new object();
        public static UserDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new UserDAO();
                    }
                    return instance;
                }
            }
        }

        // CRUD
        public List<User> GetAll()
        {
            List<User> list = new List<User>();
            try
            {
                using (var context = new HommieStoreContext())
                {
                    list = context.Users.ToList();
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return list;
        }

        public User Get(string usernameOrEmail)
        {
            User entity = null;
            try
            {
                using (var context = new HommieStoreContext())
                {
                    entity = context.Users.SingleOrDefault(item => 
                                                                item.Username.ToLower().Equals(usernameOrEmail.ToLower()) 
                                                            || item.Email.ToLower().Equals(usernameOrEmail.ToLower()));
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return entity;
        }

        public bool Exist(string usernameOrEmail)
        {
            User entity = null;
            try
            {
                using (var context = new HommieStoreContext())
                {
                    entity = context.Users.SingleOrDefault(item =>
                                                                item.Username.ToLower().Equals(usernameOrEmail.ToLower())
                                                            || item.Email.ToLower().Equals(usernameOrEmail.ToLower()));
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return entity != null;
        }

        public void Create(User entity)
        {
            try
            {
                using (var context = new HommieStoreContext())
                {
                    if (Instance.Exist(entity.Username) || Instance.Exist(entity.Email))
                    {
                        throw new Exception("Duplicated entity (username or email).");
                    }

                    context.Users.Add(entity);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Update(User entity)
        {
            try
            {
                using (var context = new HommieStoreContext())
                {
                    if (Instance.Exist(entity.Username) == false)
                    {
                        throw new Exception("The entity does not exist: " + entity.Username);
                    }

                    context.Entry<User>(entity).State = EntityState.Modified;
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message + " : " + entity.Username);
            }
        }

        public void Save(User entity)
        {
            try
            {
                if (Instance.Exist(entity.Username) || Instance.Exist(entity.Email))
                    Instance.Update(entity);
                else
                    Instance.Create(entity);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message + entity.Username);
            }
        }

        public void Delete(string usernameOrEmail)
        {
            try
            {
                using (var context = new HommieStoreContext())
                {
                    User entity = Instance.Get(usernameOrEmail);
                    if (entity == null)
                    {
                        throw new Exception("Entity is not exist.");
                    }

                    context.Users.Remove(entity);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}