namespace InterviewTasks.zadanie2
{
    internal class ToDo
    {
        public IEnumerable<(Account, Person)> MatchPersonToAccount(
             IEnumerable<Group> groups,
             IEnumerable<Account> accounts,
             IEnumerable<string> emails)
        {
            var personWithAccount = new List<(Account, Person)>();

            foreach (var account in accounts.Where(x => emails.Contains(x.EmailAddress.Email)))
            {
                personWithAccount.Add((account, GetPersonFromGroup(account.EmailAddress.Email, groups)));
            }

            return personWithAccount;
        }

        private Person GetPersonFromGroup(string emailAddress, IEnumerable<Group> groups)
        {
            foreach (var group in groups)
            {
                var person = group.People.FirstOrDefault(x => x.Emails.Any(y => y.Email == emailAddress));

                if (person is not null)
                {
                    return person;
                }
            }

            return default;
        }
    }
}
