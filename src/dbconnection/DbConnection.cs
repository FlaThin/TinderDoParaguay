using Dapper;
using Npgsql;

namespace DataBase
{
  internal class Postgreesql
  {
    public static NpgsqlConnection Connection(){
      return new NpgsqlConnection("Server=localhost;Port=5432;Database=tinderDoParaguay;User Id=postgres;Password=admin1234;");
    }


    public static bool TestConnection(){
      try {
        Connection().Query("select version()");
        return true;
      }
      catch(Exception ex) {
        throw ex;
      }
    }
  }



}