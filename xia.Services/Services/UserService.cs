using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using xia.DAL;
using xia.DAL.Models;

namespace xia.Services.Services
{
    public class UserService: BaseService
    {
        public UserService(Context dbContext) : base(dbContext)
        {
        }

        public User CreatePlayer(string name)
        {
          User _user = _Context.Users.FirstOrDefault(d => d.USR_NAME == name);
            if(_user == null)
            {
                _user.USR_NAME = name;
                
                // 初始化新玩家信息
                InitNewPlayer();
            }
            return _user;
        }

        private void InitNewPlayer()
        {
            throw new NotImplementedException();
        }
    }
}
