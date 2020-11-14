using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace homeTask9
{
    [Serializable]
    public class block
    {
        public string question { set; get; }
        public bool answer { set; get; }
        public sbyte getanswer = -1;
    }
    class Engine
    {
        
        public List<block> cont=new List<block>();
        public List<block> contForPupil = new List<block>();

        public void add(string q, bool ans)
        {
            block bl = new block();
            bl.question = q; bl.answer = ans;
            cont.Add(bl);
        }
        public bool selectQuesitons(ushort count)
        {
            contForPupil.Clear();
            if (count > cont.Count) return false;
            Random q=new Random(); ushort qq;
            List<ushort> box = new List<ushort>();
            for (ushort i=0; i<count; i++)
            {
                do
                    qq=(ushort)q.Next(cont.Count);
                while (box.Contains(qq));
                box.Add(qq);
                contForPupil.Add(cont[qq]);
            }
            
            return true;
        }
        public void del(int num)
        {
            cont.RemoveAt(num);
        }
        public void saveToXML(string filename)
        {
            XmlSerializer ser = new XmlSerializer(typeof(List<block>), filename);
            Stream f = new FileStream(filename, FileMode.OpenOrCreate, FileAccess.Write);
            ser.Serialize(f, this.cont);
            f.Close();
        }
        public void loadFromXML(string filename)
        {
            XmlSerializer ser = new XmlSerializer(typeof(List<block>), filename);
            Stream f = new FileStream(filename, FileMode.Open, FileAccess.Read);
            this.cont = (List<block>)ser.Deserialize(f);
            f.Close();
        }
        public void loadFromText()
        {
            //DirectoryInfo directory = new DirectoryInfo(AppContext.BaseDirectory);
            using (StreamReader f = new StreamReader(AppContext.BaseDirectory+@"\for files\Believe.txt"))
            {
                while (!f.EndOfStream)
                { 
                    block bl=new block();
                    bl.question=f.ReadLine();
                    bl.answer = (f.ReadLine()=="верно"?true:false);
                    cont.Add(bl);
                }
            }
        }
        public void CheckAnswers(out ushort _count, out int _progress)
        {
            _count = 0; _progress = 0;
            foreach (block i in contForPupil)
            {
                if (i.getanswer != -1) _progress++;
                if (((i.getanswer == 0) && (i.answer == false)) || ((i.getanswer == 1) && (i.answer == true)))
                    _count++;
            }
        }
        
    }
}
