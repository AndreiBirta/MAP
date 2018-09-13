using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAPiApi.Model
{
    public class User
    {
        public Guid userId { get; set; }
        private string username { get; set; }
        private string password { get; set; }
    }
}
