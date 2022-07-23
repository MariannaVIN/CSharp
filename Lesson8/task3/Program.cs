// перекинуть блинчики с пирамидки один на пирамидку три

void Towers(string with = "1", string on = "3", string some = "2", int count = 10
)
{
    if (count > 1) Towers(with, some, on, count -1);
    Console.WriteLine($"{with} >> {on}");
    if (count > 1) Towers(with, some, on, count -1);
}
Towers();