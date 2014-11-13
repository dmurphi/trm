using PetaPoco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Triemli.Repository
{
    public class BaseRepository
    {
        private static Database currentDatabase;
        public static Database getDB()
        {
            if (currentDatabase == null)
            {
                currentDatabase = new Database("TriemliSpitalConnection");
            }
            return currentDatabase;
        }
    }
}