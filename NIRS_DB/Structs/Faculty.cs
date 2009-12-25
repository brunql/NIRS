
using System;

namespace NIRS_DB.Structs
{
	
	
	public class Faculty : ActiveRecord
	{
		
     

		private int id;
        public int Id
        {
            get { return id; }
        }

		private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
			
		public Faculty()
		{
            tableName = "faculty";
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
                 query = "INSERT INTO `" + tableName + "` VALUES(null,\"" +name+ "\");";
            }
            else
            {
                query = "UPDATE `" + tableName + "` `name`=\"" + name +"\" WHERE `id`=" + id + ";";
            }

            MakeRequest(query);
        }

	}
}
