using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Messages
{
   public static class Message
    {
        public static string ProductAdded = "The product was added";
        public static string ProductDeleted = "The product was deleted";
        public static string ProductUpdated = "The product was updated";
        public static string InvalidProductName = "The name of the product is invalid";
        public static string MaintenanceTime = "It's time to fix";
    }
}
