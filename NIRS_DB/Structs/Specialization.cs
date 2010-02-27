
using System;

namespace NIRS_DB.Structs
{
	
	
	public class Specialization : ActiveRecord
	{
        public int Id { get; private set; }
        public Division Division { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        		
		public Specialization()
		{
            tableName = "spec";
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
                query = string.Format(
                    "INSERT INTO `{0}` " +
                    "VALUES (null, {1}, \"{2}\", \"{3}\");",
                    tableName,
                    Division.Id, Code, Name);
            }
            else
            {
                throw new NotImplementedException();
                //query = "UPDATE `" + tableName + "` `name`=\"" + name + "\",`code`=\"" + code +
                //    "\",`div_id`=" + div_id 					
                //    + 
                //    " WHERE `id`=" + id + ";";
            }

            MakeRequest(query);
        }

	}
}
