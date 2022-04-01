using Core.Entities.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        //static verdik cunku uygulama boyunca tek bir
        //instance oluyor bu yuzden static verdigimiz icin new'lememize gerek kalmiyor
        public static string ProductAdded = "Product added";
        public static string ProductNameInvalid = "Product name is invalid!";
        public static string MaintenanceTime = "System is in maintenance!";
        public static string ProductsListed = "Products are listed";
        public static string ProductCountOfCategoryError = "There can be at most 10 products.";
        public static string ProductNameAlreadyExists = "Product name already exists!";
        public static string AuthorizationDenied = "Authorization denied!";
        public static string UserRegistered = "Successfully registered.";
        public static string UserNotFound = "User not found!";
        public static string SuccessfulLogin = "Successfully logged in.";
        public static string UserAlreadyExists = "User already exists.";
        public static string PasswordError = "Password error.";
        public static string AccessTokenCreated = "Access token created.";
        public static string CategoryLimitExceded = "Category limit is exceded.";
        //publicler pascal case yazilir.
    }
}
