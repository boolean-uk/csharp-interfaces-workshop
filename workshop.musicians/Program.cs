using workshop.musicians.interfaces;
using workshop.musicians.musicians;

List<IPerson> people = new List<IPerson>();

EdSheeran ed = new EdSheeran();
ed.Name = "Ed Sheeran";

ArminVanBuuren armin = new ArminVanBuuren();
armin.Name = "Armin";

JayZ j = new JayZ();
j.Name = "Sean";

people.Add(ed);
people.Add(armin);
people.Add(j);


foreach(IPerson person in people)
{
    if(person is IRap)
    {
        ((IRap)person).SpitsSomeRap();
    }

    Console.WriteLine(person.Name);
}