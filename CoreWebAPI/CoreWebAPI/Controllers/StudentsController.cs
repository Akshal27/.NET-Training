using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreWebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentsController
    {
        List<StudentsModel> students = new List<StudentsModel>();

        public StudentsController()
        {
            students.Add(new StudentsModel() { StudentName = "Akshal", Age = 20 });
            students.Add(new StudentsModel() { StudentName = "Jasmine", Age = 21 });
            students.Add(new StudentsModel() { StudentName = "Jasino", Age = 22 });
        }

        [HttpGet]

        public IList<StudentsModel> Get()
        {
            return students.ToList();
        }

        [HttpPost]
        
        public IList<StudentsModel> Post(StudentsModel item)
        {
            students.Add(item);
            return students.ToList();
        }
      
        [HttpPut()]

        public IList<StudentsModel> Put(int id, StudentsModel item)
        {
            students[id].StudentName = item.StudentName;
            return students.ToList();
        }

        [HttpDelete()]

        public IList<StudentsModel> Delete(int id)
        {
            students.RemoveAt(id);
            return students.ToList();
        }

        [HttpPatch()]
        public IList<StudentsModel> Patch(int id, StudentsModel item)
        {
            students[id].StudentName = item.StudentName;
            return students.ToList();
        }
          
    
    }
}
