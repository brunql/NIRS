using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NIRS_DB.Structs
{
    public class Group : ActiveRecord
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Code { get; set; }

        private int div_id;
        public int DivisionId
        {
            get { return div_id; }
            set { div_id = value; }
        }

        private Division division;

        public Division Division
        {
            get { return division; }
            set
            {
                division = value;
                div_id = value.Id;
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
            if (id == 0)
            {
                query = "INSERT INTO `" + tableName + "` VALUES(null," + div_id + ",'"+Code+"');";
            }
            else
            {
                query = "UPDATE `" + tableName + "` `div_id`=" + div_id + ",`year`=" + Code + 
                    " WHERE `id`=" + id + ";";
            }

            MakeRequest(query);
        }

    }
}
