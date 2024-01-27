using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace TutoringCompany
{
    public class LessonList
    {
        private ObservableCollection<Lesson> lessons = new ObservableCollection<Lesson>();

        public ObservableCollection<Lesson> Lessons => lessons;

        public void AddLesson(Lesson lesson)
        {
            lessons.Add(lesson);
        }

        public void RemoveLesson(Lesson lesson)
        {
            lessons.Remove(lesson);
        }
        public void Sort()
        {
            ObservableCollection<Lesson> sortedLessons = new ObservableCollection<Lesson>(lessons.OrderBy(lesson => lesson.Student.Surname));
            lessons.Clear();
            lessons = sortedLessons;
        }
    }
}
