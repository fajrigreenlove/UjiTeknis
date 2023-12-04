using Test.DTO;
using static System.Net.Mime.MediaTypeNames;

class Program
{
    static void Main(string[] args)
    {

        string result = "";
        #region input
        var protectedData = new protectedData
        {
            ShieldLastRun = "data"
        };


        var application = new applicationDto
        {
            Protected = protectedData,
        };

        #endregion

        #region Proses
        if (application?.Protected  != null)
        {

            result = application.Protected.ShieldLastRun;
        }
        #endregion

        #region Output
        Console.WriteLine(result);
        return;
        #endregion


    }
}

