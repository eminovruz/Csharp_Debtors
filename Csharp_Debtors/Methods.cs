static class Methods
{
    static public void Show<Debtor>(this IEnumerable<Debtor> debtors)
    {
        foreach (var debtor in debtors)
        {
            Console.WriteLine(debtor);
        }
    }
}
