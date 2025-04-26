string NRZ(string input)
{
    Console.WriteLine("NRZ:"+input);
    return input;
}
string NRZI(string input)
{
    string output = "";
    int impuls = 0;
    foreach (char i in input)
    {
        if (i == '0')
        {
            output = output + impuls.ToString();
        }
        else
        {
            if (impuls == 0)
            {
                impuls = 1;
                output = output + impuls.ToString();
            }
            else
            {
                impuls = 0;
                output = output + impuls.ToString();
            }
        }
    }
    Console.WriteLine("NRZI:" + output);
    return input;
}

string AMI(string input)
{
    string output = "";
    int impuls = 1;
    foreach (char i in input)
    {
        if (i == '0')
        {
            output = output + i.ToString();
        }
        else
        {
            if (impuls == 1)
            {
                output = output + impuls.ToString();
                impuls = -1;
            }
            else
            {
                output = output + impuls.ToString();
                impuls = 1;

            }
        }
    }
    Console.WriteLine("AMI:" + output);
    return input;
}
string ManchCode(string input)
{
    string output = "";
    foreach (char i in input)
    {
        if (i == '0')
        {
            output = output+"10";
        }
        else
        {
            output = output + "01";
        }
    }
    Console.WriteLine("Манчестерский код:" + output);
    return input;
}


string group = "010110";     //22
string number = "00110";     //6
string lastName = "0111";    //7
string firstName = "0110";   //6
string input = group +number + "000000000" + lastName + firstName;
Console.WriteLine("Исходный код:"+input+"\n" + "Зашифрованный код:");
NRZ(input);
NRZI(input);
AMI(input);
ManchCode(input);
/*string a = "1";
int b = 0;
a = b.ToString();
Console.WriteLine(a);*/
Console.ReadKey();  