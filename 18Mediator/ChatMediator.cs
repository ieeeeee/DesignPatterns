using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18Mediator
{
    /// <summary>
    /// 聊天中介
    /// </summary>
    public class ChatMediator
    {
        public List<Student> StudentList = new List<Student>();

        public ChatMediator(List<Student> studentList)
        {
            StudentList = studentList;
        }

        public void SendMessage(Student from,string text)
        {
            foreach(Student student in StudentList.Where(s=>!s.Name.Equals(from.Name)))
            {
                student.ReceiveMessage(text);
            }
        }
    }
}
