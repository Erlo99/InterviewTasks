namespace InterviewTasks.Zadanie1.Implementation
{
    public class Implementation
    {
        public static IEnumerable<PersonWithEmail> Flatten(IEnumerable<Person> people)
        {
            var personWithEmailList = new List<PersonWithEmail>();

            foreach(var person in people)
            {
                personWithEmailList.AddRange(GetPersonWithEmail(person));
            }

            return personWithEmailList;
        }

        private static IEnumerable<PersonWithEmail> GetPersonWithEmail(Person person)
        {
            foreach (var email in person.Emails)
            {
                yield return new PersonWithEmail() 
                { 
                    FormattedEmail = email.Email,
                    SanitizedNameWithId = person.Name + person.Id
                };
            }
        }

        //takie mapowanie może być wykorzystane gdy potrzebujemy listy zarejestrowanych
        //użytkowników za pomocą email. Konsekwencją tego działania jest duplikowanie 
        //rekordów z nazwą oraz id użytkownika
    }
}
