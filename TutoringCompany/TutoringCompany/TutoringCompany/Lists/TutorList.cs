using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TutoringCompany
{
    public class TutorList
    {
        private ObservableCollection<Tutor> tutors = new ObservableCollection<Tutor>();

        public ObservableCollection<Tutor> Tutors => tutors;

        public void AddTutor(Tutor tutor)
        {
            tutors.Add(tutor);
        }

        public void RemoveTutor(Tutor tutor)
        {
            tutors.Remove(tutor);
        }
        public void Sort()
        {
            ObservableCollection<Tutor> sortedTutors = new ObservableCollection<Tutor>(tutors.OrderBy(tutor => tutor.Surname));
            tutors.Clear();
            tutors = sortedTutors;
        }
    }
}
