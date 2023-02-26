public class QuestionData
{
    public List<Employee> GetEmployee()
    {
         List<Employee> emps = new List<Employee>();
        emps.Add(new Employee{ Id = 1, Question = "The International Literacy Day is observed on", Ans = "1= Sep 8 2=Nov 28 3=May 2 4=Sep 22",Ansid = 1});
        emps.Add(new Employee{ Id = 2, Question = "The language of Lakshadweep. a Union Territory of India, is",  Ans= "1=Tamil 2=Hindi 3=Malayalam 4=Telugu", Ansid = 3});
        emps.Add(new Employee{ Id = 3, Question = "In which group of places the Kumbha Mela is held every twelve years?", Ans = "1=Ujjain. Purl; Prayag. Haridwar 2=Prayag. Haridwar, Ujjain,. Nasik 3=Rameshwaram. Purl, Badrinath. Dwarika 4=Chittakoot, Ujjain, Prayag,'Haridwar", Ansid = 2});
         emps.Add(new Employee{ Id = 4, Question = "Bahubali festival is related to", Ans = "1= Islam 8 2=Hinduism  3=Buddhism 4=Jainism",Ansid = 4});
          emps.Add(new Employee{ Id = 5, Question = "Which day is observed as the World Standards  Day?", Ans = "1= June 26  2=Oct 14 3=Nov 15 4=Dec 2",Ansid = 2});
           emps.Add(new Employee{ Id = 6, Question = "Which of the following was the theme of the World Red Cross and Red Crescent Day?", Ans = "1= 'Dignity for all - focus on women' 2=Dignity for all - focus on Children' 3=Focus on health for all 4=ourishment for all-focus on children",Ansid = 2});
            emps.Add(new Employee{ Id = 7, Question = "September 27 is celebrated every year as", Ans = "1= Teachers' Day 2=National Integration Day 3=World Tourism Day 4=International Literacy Day",Ansid = 3});
             emps.Add(new Employee{ Id = 8, Question = "Who is the author of 'Manas Ka-Hans' ?", Ans = "1= Khushwant Singh 2=Prem Chand 3=Jayashankar Prasad 4=Amrit Lal Nagar",Ansid = 4});
              emps.Add(new Employee{ Id = 9, Question = "The death anniversary of which of the following leaders is observed as Martyrs' Day?", Ans = "1= Smt. Indira Gandhi 2=PI. Jawaharlal Nehru 3=Mahatma Gandhi 4=Lal Bahadur Shastri",Ansid = 3});
               emps.Add(new Employee{ Id = 10, Question = "Who is the author of the epic 'Meghdoot", Ans = "1= Vishakadatta 2=Valmiki 3=Banabhatta 4=Kalidas",Ansid = 4});
                emps.Add(new Employee{ Id = 11, Question = "Thillana is a format of", Ans = "1= Kuchipudi2=Odhisa 3=Bharathatyarn 4=Kathak",Ansid = 3});
                 emps.Add(new Employee{ Id = 12, Question = "Most 'ancient musical' instrument among the following is", Ans = "1= Sarod 2=Tabla 3=sitar 4=Veena",Ansid = 4});
                  emps.Add(new Employee{ Id = 13, Question = "Of which of the following states is Nautanki, a folk dance?", Ans = "1= Utter pradesh 2=Arunchal pradesh 3=Meghalaya 4=Orissa",Ansid = 1});
                   emps.Add(new Employee{ Id = 14, Question = "Which of the following Academy is responsible for fostering the development of dance, drama and music in India?", Ans = "1= Lalit Kala Acaderny 2=Sahitya Academy 3=National School of Drama 4=National School of Drama",Ansid = 4});
                    emps.Add(new Employee{ Id = 15, Question = "The headquarters of the Sahitya Academy is at", Ans = "1= Mumbai 2=New delhi 3=chennai 2 4=Kolkata",Ansid = 2});
        return emps;
    }
}