
using System;

namespace NIRS_DB.Structs
{
	
	
	public class Faculty : ActiveRecord
	{
        public int Id { get; private set; }
        public string Name { get; set; }
        public string FullName { get; set; }


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
            if (Id == 0)
            {
                query = string.Format("INSERT INTO `{0}` VALUES( null, \"{1}\", \"{2}\" );", tableName, Name, FullName);
            }
            else
            {
                throw new NotImplementedException();
                //query = "UPDATE `" + tableName + "` `name`=\"" + name +"\" WHERE `id`=" + id + ";";
            }

            MakeRequest(query);
        }

	}
}
