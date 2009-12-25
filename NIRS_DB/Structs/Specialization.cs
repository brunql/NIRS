
using System;

namespace NIRS_DB.Structs
{
	
	
	public class Specialization : ActiveRecord
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

        private int div_id;

        private Division div;

        public Division Division
        {
            get { return div; }
            set
            {
                div = value;
                div_id = value.Id;
            }
        }
		
		private string code;
		
		public string Code
		{
			get { return code; }
			set { code = value;}
		}

		
		public Specialization()
		{
			
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
                query = "INSERT INTO `" + tableName + "` VALUES(null,\"" + name + "\",\""+code+"\",\""+ name +"\");";
            }
            else
            {
                query = "UPDATE `" + tableName + "` `name`=\"" + name + "\",`code`=\"" + code +
					"\",`div_id`=" + div_id 					
					+ 
                    " WHERE `id`=" + id + ";";
            }

            MakeRequest(query);
        }

	}
}
