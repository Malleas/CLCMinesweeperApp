using CLCMinesweeperApp.Models;
using CLCMinesweeperApp.Services.Data;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace GameServices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public string Bar()
        {
            return "Hello this is bar";
        }

        public string Foo()
        {
            return "hello this is foo";
        }

        bool IService1.SaveGame(string data)
        {
            GameDAO game = new GameDAO();
            GameObject gameObject = new GameObject(data);
            bool success = game.SaveGame(gameObject);

            return success;
        }
    }
}
