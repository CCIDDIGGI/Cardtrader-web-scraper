using Cardtrader_web_scraper.Model;
using Microsoft.AspNetCore.Mvc;

namespace Cardtrader_web_scraper.Controllers
{
    public class UserController: Controller
    {
        private List<User> users = new List<User>();

        // Constructor
        public UserController()
        {
            
        }

        #region User Actions

        /// <summary>
        /// Adds a new user to the current users list
        /// </summary>
        /// <param name="user">The user to add to the list</param>
        public void addUser(User user)
        {
            users.Add(user);   
        }

        #endregion
    }
}
