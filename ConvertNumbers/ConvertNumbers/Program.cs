namespace ConvertNumbers
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] Result = ConvertNumber(999999);
            Console.WriteLine(string.Join(" ", Result));

            static string[] ConvertNumber(int number)
            {
                if (number == 0) {
                    return new string[] { "Sefr" };
                }

                string[] units = { "", "Wa7ed ", "Etnen", "Tlata", "Arba3a", "khamsa", "Seta", "Sab3a", "Tmania", "Tes3a" };
                string[] tens = { "", "3ashra", "3eshreen", "Tlateen", "Arb3en", "5amseen", "Steen", "Sab3een", "Tmaneen", "Ts3een" };
                string[] teens = { "", "7dasher", "Atnasher", "Tlatasher", "Arb3tasher", "5amstasher", "Setasher", "Sab3tasher", "Tmntasher", "Ts3tasher" };
                string[] hundreds = { "", "Mya", "Mteen", "Tltmia", "Rob3mia", "5omsomia","Stomia", "Sob3omia", "Tomnmia", "Tos3omia" };
                string[] thousands = { "", "Alf", "Alfeen", "TlatAlaf", "Arb3Alaf", "KhamsAlaf", "SetAlaf", "Sab3Alaf", "TmnAlaf", "Ts3Alaf" };
                string[] hundredthousands = { "", "Met", "Mteen","Tltmia", "Rob3mia", "5omsomia", "Stomia", "Sob3omia", "Tomnmia", "Tos3omia" };

                int unitsDigit = number % 10;
                int tensDigit = (number % 100)/10;
                int teensDigit = number % 10;
                int hundradDigit = (number / 100) % 10;
                
                int thousandDigit = (number / 1000) % 10;
                int hundredthousandDigit = (number / 100000);

                int hundredthousandtensDigit = (number / 10000) % 10;
                int hundredthousandunitsDigit = (number / 1000)  % 10;

                string hundredthousand = (hundredthousandDigit > 0)  ? hundredthousands[hundredthousandDigit]  : "";
        

                string hundredthousandtens = (hundredthousandunitsDigit == 0 && hundredthousandtensDigit > 0) ? " Wa " + tens[hundredthousandtensDigit] : "";
                string hundredthousandunits = (hundredthousandunitsDigit > 0 && hundredthousandtensDigit == 0&& thousandDigit ==0) ? " Wa "+ units[hundredthousandunitsDigit]  : "";
                string hundredthousandteens = (hundredthousandunitsDigit > 0 && hundredthousandtensDigit == 1) ? " Wa " + teens[hundredthousandunitsDigit] : "";
                string hundredthousandtenunit = (hundredthousandtensDigit > 0 && hundredthousandunitsDigit > 0 && hundredthousandtensDigit != 1) ? " Wa " + units[hundredthousandunitsDigit] + " Wa " + tens[hundredthousandtensDigit] : "";


                string alf = (hundredthousandDigit > 0) ? " Alf" + " Wa" : "";
                string thousand =( thousandDigit >0 && hundredthousandtensDigit == 0  && hundredthousandDigit ==0) ? thousands[thousandDigit] +" Wa" : "";
                string hundred = (hundradDigit > 0) ? hundreds[hundradDigit]  : "";
               

                string teen = (unitsDigit > 0 && tensDigit == 1) ? " Wa " + teens[teensDigit] : "";
                string unit = (unitsDigit > 0  && tensDigit == 0) ? units[unitsDigit]  : "";
                string ten = (tensDigit > 0 && unitsDigit == 0) ? " Wa " + tens[tensDigit] : "";

                string tenunit = (tensDigit > 0 && unitsDigit > 0 && tensDigit != 1) ? units[unitsDigit] + " Wa "+ tens[tensDigit] : "";

                return new string[] { hundredthousand, hundredthousandunits, hundredthousandtens, hundredthousandteens, hundredthousandtenunit ,  alf, thousand ,hundred, unit,ten, teen, tenunit };

            }


        }
    }
}