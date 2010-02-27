using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NIRS_DB.Structs
{
    public class Group : ActiveRecord
    {
        public int Id { get; private set; }
        public string Code { get; set; }
        public int DivisionId { get; set; }


        private Division division;

        public Division Division
        {
            get { return division; }
            set
            {
                division = value;
                DivisionId = value.Id;
            }
        }
        
        public Group()
        {
            tableName = "group";
        }

        public override ActiveRecord Find(DBCriteria crit)
        {
            throw new NotImplementedException();
        }

        public override void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public override void Save()
        {
            string query = "";
            if (Id == 0)
            {
                query = string.Format("INSERT INTO `{0}` VALUES(null, {1}, '{2}');", tableName, DivisionId, Code);
            }
            else
            {
                throw new NotImplementedException();
                //query = "UPDATE `" + tableName + "` `div_id`=" + div_id + ",`year`=" + Code + 
                //    " WHERE `id`=" + id + ";";
            }

            MakeRequest(query);
        }

    }
}
