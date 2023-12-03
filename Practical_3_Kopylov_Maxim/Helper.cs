using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Practical_3_Kopylov_Maxim;

namespace Practical_3_Kopylov_Maxim
{
    public class Helper
    {
        public static Models.EntityBuilding s_stroitel;

        public static Models.EntityBuilding getContext()
        {
            if(s_stroitel == null)
            {
                s_stroitel = new Models.EntityBuilding();
            }
            return s_stroitel;
        }
        public void CreateUsers(Models.avtorization avtorization)
        {
            
            s_stroitel.avtorization.Add(avtorization);
            s_stroitel.SaveChanges();
        }
        public void RemoveUsers(int idUsers)
        {
            var users = s_stroitel.avtorization.Find(idUsers);
            s_stroitel.avtorization.Remove(users);
            s_stroitel.SaveChanges();
        }
        public void FiltrUsers()
        {
            var users = s_stroitel.avtorization.Where(x => x.login.StartsWith("a") || x.login.StartsWith("z"));
        }
        public void SortUsers()
        {
            var users = s_stroitel.avtorization.OrderBy(x => x.login);
        }
    }
}
