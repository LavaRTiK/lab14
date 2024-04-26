using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab14
{
    public class DB
    {
        private List<Concert> list;

        public DB()
        {
            this.list = new List<Concert>();
        }

        public void Add(Concert consert)
        {
            //модальная форма для даних концерт
            if(list.Count == 0)
            {
                consert.id = 1;
            }
            else
            {
                consert.id = list.Select(x => x.id).Max() + 1;
            }
            list.Add(consert); 
        }
        public void Removed(int id)
        {
            list.Remove(list.FirstOrDefault(x => x.id == id));
        }
        public void Edit(Concert newobj, int id)
        {
            int index = list.FindIndex(x => x.id == id);
            list[index].performer = newobj.performer;
            list[index].data = newobj.data;
            list[index].venue = newobj.venue;
            list[index].number_of_seats = newobj.number_of_seats;

        }
        public void CreateTestData()
        {
            list.Add(new Concert("test",new DateTime(2003,07,27,12,30,00),"Добрицький",210) { id = 1});
            list.Add(new Concert("test", new DateTime(2004, 02, 11, 11, 00, 00), "Добрицьки2й", 310) { id = 2 });
            list.Add(new Concert("test", new DateTime(2003, 04, 15, 10, 30, 00), "Добрицький3", 110) { id = 3 });
            list.Add(new Festival("test", new DateTime(2001, 01, 23, 10, 30, 00), "Добрицький4", 110) { id = 5 });

            //new DataTime()с
        }
        public void SaveDBJson()
        {
            var options = new JsonSerializerOptions { WriteIndented = true  };
            string json = JsonSerializer.Serialize(list,options);
            if (!File.Exists("SaveDB.json"))
            {
                File.Create("SaveDB.json");
            }
            File.WriteAllText("SaveDB.json",json);
        }

        public void LoadDBJson()
        {
            if (!File.Exists("SaveDB.json"))
            {
                return;
            }
            string json = File.ReadAllText("SaveDB.json");
            var decod = JsonSerializer.Deserialize<List<Concert>>(json);
            this.list = decod;
        }
        public List<Concert> GetList()
        {
            return list;
        }
    }
}
