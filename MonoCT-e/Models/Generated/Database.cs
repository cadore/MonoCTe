using MonoCT_e.Connection;
using PetaPoco;
using System;
using System.Collections.Generic;

namespace MonoCT_e
{

    public partial class MonoCTeRepo : Database
    {
        public MonoCTeRepo() : base(ConnectionUtil.ConnectionString, ConnectionUtil.InvariantName)
        {
            CommonConstruct();
        }

        public MonoCTeRepo(string connectionStringName) : base(connectionStringName)
        {
            CommonConstruct();
        }

        partial void CommonConstruct();

        public interface IFactory
        {
            MonoCTeRepo GetInstance();
        }

        public static IFactory Factory { get; set; }
        public static MonoCTeRepo GetInstance()
        {
            if (_instance != null)
                return _instance;

            if (Factory != null)
                return Factory.GetInstance();
            else
                return new MonoCTeRepo();
        }

        [ThreadStatic]
        static MonoCTeRepo _instance;

        public override void OnBeginTransaction()
        {
            if (_instance == null)
                _instance = this;
        }

        public override void OnEndTransaction()
        {
            if (_instance == this)
                _instance = null;
        }


        public class Record<T> where T : new()
        {
            public static MonoCTeRepo repo { get { return MonoCTeRepo.GetInstance(); } }
            public bool IsNew() { return repo.IsNew(this); }
            public object Insert() { return repo.Insert(this); }

            public void Save() { repo.Save(this); }
            public int Update() { return repo.Update(this); }

            public int Update(IEnumerable<string> columns) { return repo.Update(this, columns); }
            public static int Update(string sql, params object[] args) { return repo.Update<T>(sql, args); }
            public static int Update(Sql sql) { return repo.Update<T>(sql); }
            public int Delete() { return repo.Delete(this); }
            public static int Delete(string sql, params object[] args) { return repo.Delete<T>(sql, args); }
            public static int Delete(Sql sql) { return repo.Delete<T>(sql); }
            public static int Delete(object primaryKey) { return repo.Delete<T>(primaryKey); }
            public static bool Exists(object primaryKey) { return repo.Exists<T>(primaryKey); }
            public static bool Exists(string sql, params object[] args) { return repo.Exists<T>(sql, args); }
            public static T SingleOrDefault(object primaryKey) { return repo.SingleOrDefault<T>(primaryKey); }
            public static T SingleOrDefault(string sql, params object[] args) { return repo.SingleOrDefault<T>(sql, args); }
            public static T SingleOrDefault(Sql sql) { return repo.SingleOrDefault<T>(sql); }
            public static T FirstOrDefault(string sql, params object[] args) { return repo.FirstOrDefault<T>(sql, args); }
            public static T FirstOrDefault(Sql sql) { return repo.FirstOrDefault<T>(sql); }
            public static T Single(object primaryKey) { return repo.Single<T>(primaryKey); }
            public static T Single(string sql, params object[] args) { return repo.Single<T>(sql, args); }
            public static T Single(Sql sql) { return repo.Single<T>(sql); }
            public static T First(string sql, params object[] args) { return repo.First<T>(sql, args); }
            public static T First(Sql sql) { return repo.First<T>(sql); }
            public static List<T> Fetch(string sql, params object[] args) { return repo.Fetch<T>(sql, args); }
            public static List<T> Fetch(Sql sql) { return repo.Fetch<T>(sql); }
            public static List<T> Fetch(long page, long itemsPerPage, string sql, params object[] args) { return repo.Fetch<T>(page, itemsPerPage, sql, args); }
            public static List<T> Fetch(long page, long itemsPerPage, Sql sql) { return repo.Fetch<T>(page, itemsPerPage, sql); }
            public static List<T> SkipTake(long skip, long take, string sql, params object[] args) { return repo.SkipTake<T>(skip, take, sql, args); }
            public static List<T> SkipTake(long skip, long take, Sql sql) { return repo.SkipTake<T>(skip, take, sql); }
            public static Page<T> Page(long page, long itemsPerPage, string sql, params object[] args) { return repo.Page<T>(page, itemsPerPage, sql, args); }
            public static Page<T> Page(long page, long itemsPerPage, Sql sql) { return repo.Page<T>(page, itemsPerPage, sql); }
            public static IEnumerable<T> Query(string sql, params object[] args) { return repo.Query<T>(sql, args); }
            public static IEnumerable<T> Query(Sql sql) { return repo.Query<T>(sql); }
            public static String Concat(object s) { return String.Format("%{0}%", s); }

            public static DateTime Now()
            {
                return repo.ExecuteScalar<DateTime>("SELECT LOCALTIMESTAMP");    
            }
        }
    }

    [TableName("users")]
    [PrimaryKey("id")]
    [ExplicitColumns]
    public class user : MonoCTeRepo.Record<user>
    {
        [Column] public long id { get; set; }
        [Column] public string full_name { get; set; }
        [Column] public string login { get; set; }
        [Column] public string password { get; set; }
        [Column] public DateTime last_acess { get; set; }
    }

    [TableName("drivers")]
    [PrimaryKey("id")]
    [ExplicitColumns]
    public class driver : MonoCTeRepo.Record<driver>
    {
        [Column]
        public long id { get; set; }
        [Column]
        public string full_name { get; set; }
        [Column]
        public string cpf { get; set; }
        [Column]
        public string phone { get; set; }
        [Column]
        public long business_id { get; set; }
    }

    [TableName("vehicles")]
    [PrimaryKey("id")]
    [ExplicitColumns]
    public class vehicle : MonoCTeRepo.Record<vehicle>
    {
        [Column]
        public long id { get; set; }
        [Column]
        public string cod_renavam { get; set; }
        [Column]
        public string board { get; set; }
        [Column]
        public string tare_kg { get; set; }
        [Column]
        public string capacity_kg { get; set; }
        [Column]
        public string capacity_m3 { get; set; }
        [Column]
        public int type_wheeled { get; set; }
        [Column]
        public int type_body { get; set; }
        [Column]
        public int type_vehicle { get; set; }
        [Column]
        public int property { get; set; }
        [Column]
        public bool vehicles_is_business { get; set; }
        [Column]
        public long state_id { get; set; }
        [Column]
        public long customer_id { get; set; }
        [Column]
        public long business_id { get; set; }
    }

    [TableName("states")]
    [PrimaryKey("id")]
    [ExplicitColumns]
    public class state : MonoCTeRepo.Record<state>
    {
        [Column]
        public long id { get; set; }
        [Column]
        public string name { get; set; }
        [Column]
        public string symbol { get; set; }
        [Column]
        public int cod_ibge { get; set; }
    }

    [TableName("citys")]
    [PrimaryKey("id")]
    [ExplicitColumns]
    public class city : MonoCTeRepo.Record<city> {
        [Column] public long id { get; set; } 
        [Column] public string name { get; set; } 
        [Column] public int cod_ibge { get; set; } 
        [Column] public int population { get; set; } 
        [Column] public int demographic { get; set; } 
        [Column] public string gentilic { get; set; } 
        [Column] public int area { get; set; } 
        [Column] public string zip_code { get; set; }
        [Column] public long state_id { get; set; }
    }

    [TableName("customers")]
    [PrimaryKey("id")]
    [ExplicitColumns]
    public class customer : MonoCTeRepo.Record<customer>
    {
        [Column]
        public long id { get; set; }
        [Column]
        public int type_document { get; set; }
        [Column]
        public string document { get; set; }
        [Column]
        public string ie { get; set; }
        [Column]
        public string ie_suframa { get; set; }
        [Column]
        public string corporate_name { get; set; }
        [Column]
        public string fantasy_name { get; set; }
        [Column]
        public string mobile { get; set; }
        [Column]
        public string email { get; set; }
        [Column]
        public string phone { get; set; }
        [Column]
        public long address_id { get; set; }
        [Column]
        public long business_id { get; set; }
    }

    [TableName("address")]
    [PrimaryKey("id")]
    [ExplicitColumns]
    public class address : MonoCTeRepo.Record<address>
    {
        [Column]
        public long id { get; set; }
        [Column]
        public string name { get; set; }
        [Column]
        public string district { get; set; }
        [Column]
        public string number { get; set; }
        [Column]
        public string complement { get; set; }
        [Column]
        public string cep { get; set; }
        [Column]
        public long state_id { get; set; }
        [Column]
        public long city_id { get; set; }        
    }

    [TableName("business")]
    [PrimaryKey("id")]
    [ExplicitColumns]
    public class business : MonoCTeRepo.Record<business>
    {
        [Column]
        public long id { get; set; }
        [Column]
        public string cnpj { get; set; }
        [Column]
        public string ie { get; set; }
        [Column]
        public string corporate_name { get; set; }
        [Column]
        public string fantasy_name { get; set; }
        [Column]
        public string phone { get; set; }
        [Column]
        public bool send_cte { get; set; }
        [Column]
        public string tokenNS { get; set; }
        [Column]
        public long address_id { get; set; }
    }


}