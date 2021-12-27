using System;                  
using System.Collections.Generic;                  
using System.Data;                  
using System.Linq;                  
using EEntityCore.DB.Abstracts;                  
using EEntityCore.DB.MSSQL.Interfaces;                  
using ELibrary.Standard.VB.Objects;                  
using ELibrary.Standard.VB.Types;                  
using ELibrary.Standard.VB.Modules;                  
using EEntityCore.DB.MSSQL.Schemas;                  
using EEntityCore.DB.MSSQL;                  
using EEntityCore.DB.Modules;                  
using static EWebFrameworkCore.Dev.DBEntities.DatabaseSchema.DatabaseInit;
using EWebFrameworkCore.Dev.DBEntities.DatabaseSchema;

namespace EWebFrameworkCore.Dev.DBEntities.DatabaseSchema.AuxTables.AuxTables.charity                  
{                  

    public class T___AttendeeDetail : SimpleTablePlugIn, IDataColumnDefinitionsHolder, IDBTableDefinitionPlugIn                  
    {                  
                  
 #region Constructors                  
                  
                  
       static T___AttendeeDetail()                  
        {                  
          ColumnDefns = new Dictionary<string, DataColumnDefinition>();                  
          defID = new DataColumnDefinition(TableColumnNames.ID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.PRIMARY);
          defCenterVisitationID = new DataColumnDefinition(TableColumnNames.CenterVisitationID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.UNIQUE);
          defBeneficiaryID = new DataColumnDefinition(TableColumnNames.BeneficiaryID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.UNIQUE);
          defIsPresent = new DataColumnDefinition(TableColumnNames.IsPresent.ToString(), typeof(bool),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defPictureStoredPath = new DataColumnDefinition(TableColumnNames.PictureStoredPath.ToString(), typeof(string),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defEducation = new DataColumnDefinition(TableColumnNames.Education.ToString(), typeof(string),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defEmotion = new DataColumnDefinition(TableColumnNames.Emotion.ToString(), typeof(string),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defHealth = new DataColumnDefinition(TableColumnNames.Health.ToString(), typeof(string),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defSpiritual = new DataColumnDefinition(TableColumnNames.Spiritual.ToString(), typeof(string),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defSocial = new DataColumnDefinition(TableColumnNames.Social.ToString(), typeof(string),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defTalent = new DataColumnDefinition(TableColumnNames.Talent.ToString(), typeof(string),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defObservations = new DataColumnDefinition(TableColumnNames.Observations.ToString(), typeof(string),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defChristSmilesFeedBack = new DataColumnDefinition(TableColumnNames.ChristSmilesFeedBack.ToString(), typeof(string),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defCreatedAt = new DataColumnDefinition(TableColumnNames.CreatedAt.ToString(), typeof(DateTime),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defUpdatedAt = new DataColumnDefinition(TableColumnNames.UpdatedAt.ToString(), typeof(DateTime),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defCreatedByID = new DataColumnDefinition(TableColumnNames.CreatedByID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.FOREIGN);
          defUpdatedByID = new DataColumnDefinition(TableColumnNames.UpdatedByID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.FOREIGN);


          ColumnDefns.Add(defID.ColumnName, defID); 
          ColumnDefns.Add(defCenterVisitationID.ColumnName, defCenterVisitationID); 
          ColumnDefns.Add(defBeneficiaryID.ColumnName, defBeneficiaryID); 
          ColumnDefns.Add(defIsPresent.ColumnName, defIsPresent); 
          ColumnDefns.Add(defPictureStoredPath.ColumnName, defPictureStoredPath); 
          ColumnDefns.Add(defEducation.ColumnName, defEducation); 
          ColumnDefns.Add(defEmotion.ColumnName, defEmotion); 
          ColumnDefns.Add(defHealth.ColumnName, defHealth); 
          ColumnDefns.Add(defSpiritual.ColumnName, defSpiritual); 
          ColumnDefns.Add(defSocial.ColumnName, defSocial); 
          ColumnDefns.Add(defTalent.ColumnName, defTalent); 
          ColumnDefns.Add(defObservations.ColumnName, defObservations); 
          ColumnDefns.Add(defChristSmilesFeedBack.ColumnName, defChristSmilesFeedBack); 
          ColumnDefns.Add(defCreatedAt.ColumnName, defCreatedAt); 
          ColumnDefns.Add(defUpdatedAt.ColumnName, defUpdatedAt); 
          ColumnDefns.Add(defCreatedByID.ColumnName, defCreatedByID); 
          ColumnDefns.Add(defUpdatedByID.ColumnName, defUpdatedByID); 
                  
          ForeignKeys = new List<IDBTableDefinitionPlugIn.ForeignKeyDefinition>();                  
                  

            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_charity_AttendeeDetail_CenterVisitationID", false, IDBTableDefinitionPlugIn.ReferentialAction.CASCADE,                  
                    "charity.AttendeeDetail", "charity.CenterVisitation"                  
                            ));                  
            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_charity_AttendeeDetail_BeneficiaryID", false, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "charity.AttendeeDetail", "charity.Beneficiary"                  
                            ));                  
            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_charity_AttendeeDetail_CreatedByID", false, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "charity.AttendeeDetail", "auth.Users"                  
                            ));                  
            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_charity_AttendeeDetail_UpdatedByID", false, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "charity.AttendeeDetail", "auth.Users"                  
                            ));                  

          }


                  
       public T___AttendeeDetail() : base()                  
        {                  
        }                  


                  
   #region Full Access                                    
                  
        // Full Access means initial data is loaded directly from database, so DBConn MUST be provided                                                      
                  
        /// <summary>                                                      
        /// FULL ACCESS. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="TableName"></param>                                                      
        /// <remarks></remarks>                                    
        public T___AttendeeDetail(All__DBs DBConn) : base(DBConn)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pTargettedRowID">Only works if the table contains a column named ID</param>                                                      
        /// <remarks></remarks>                                    
        public T___AttendeeDetail(All__DBs DBConn, long pTargettedRowID) : base(DBConn,  pTargettedRowID: pTargettedRowID)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pSQL">Load table with your own SQL</param>                                                      
        /// <remarks></remarks>                                    
        public T___AttendeeDetail(All__DBs pDBConn, string pSQL) : base(pDBConn,  pSQL)                                    
        {                                    
        }                                    
                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <param name="pSQL">Load table with your own SQL</param>                                                      
        /// <remarks></remarks>                                    
        public T___AttendeeDetail(All__DBs pDBConn,  string pSQL, long pTargettedRowID) : base(pDBConn, pSQL, pTargettedRowID)                                    
        {                                    
        }                                    
                                    
        #endregion                                    
                                    
                                    
   #region Partial Access                                    
                                    
        // Partial Simply means initial data is loaded directly from user but DBConn might be provided for reloadClass function to work                                                      
                                    
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="pTableRows"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___AttendeeDetail(DataRowCollection pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)                                    
        {                                    
        }                  
                  
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="pTableRows"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___AttendeeDetail(IEnumerable<DataRow> pTableRows) : base(pTableRows)                  
        {                  
        }                  
                  
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="pTableRows"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___AttendeeDetail(IEnumerable<DataRow> pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="FullTable"></param>                                                      
        /// <param name="TargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___AttendeeDetail(DataTable FullTable, long TargettedRowID) : base(FullTable, TargettedRowID)                                    
        {                                    
        }                                    
                                            
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="FullTable"></param>                                                      
        /// <param name="TargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___AttendeeDetail(DataTable FullTable) : base(FullTable)                                    
        {                                    
        }                                    
                                    
                                    
        #endregion                                    
                                    
                                    
   #region Shallow Access                                    
        // In the real definition, shallow reference partial. Just that it means partial with no DBConn                                                      
                                    
        /// <summary>                                                      
        /// Shallow Access                                                      
        /// </summary>                                                      
        /// <param name="TargettedRow"></param>                                                      
        /// <remarks>Assuming this Row has a Column Called ID and It will be assigned</remarks>                                    
        public T___AttendeeDetail(DataRow TargettedRow) : base(TargettedRow)                                    
        {                                    
        }                                    
                                    
        #endregion                                    
                                    
                                    
                                    
                                    
 #endregion                                    
                                    

 #region Consts and Enums                       

       public const string TABLE_NAME = "charity.AttendeeDetail";
       public const string AttendeeDetail__NO__BINARY___SQL_FILL_QUERY = "SELECT [ID], [CenterVisitationID], [BeneficiaryID], [IsPresent], [PictureStoredPath], [Education], [Emotion], [Health], [Spiritual], [Social], [Talent], [Observations], [ChristSmilesFeedBack], [CreatedAt], [UpdatedAt], [CreatedByID], [UpdatedByID] FROM charity.AttendeeDetail";
       public const string AttendeeDetail__ALL_COLUMNS___SQL_FILL_QUERY = "SELECT [ID], [CenterVisitationID], [BeneficiaryID], [IsPresent], [PictureStoredPath], [Education], [Emotion], [Health], [Spiritual], [Social], [Talent], [Observations], [ChristSmilesFeedBack], [CreatedAt], [UpdatedAt], [CreatedByID], [UpdatedByID] FROM charity.AttendeeDetail";


       public enum TableColumnNames
       {

           ID,
           CenterVisitationID,
           BeneficiaryID,
           IsPresent,
           PictureStoredPath,
           Education,
           Emotion,
           Health,
           Spiritual,
           Social,
           Talent,
           Observations,
           ChristSmilesFeedBack,
           CreatedAt,
           UpdatedAt,
           CreatedByID,
           UpdatedByID
       } 



       public enum TableConstraints{

           pk_charity_AttendeeDetail, 
           fk_charity_AttendeeDetail_CenterVisitationID, 
           fk_charity_AttendeeDetail_BeneficiaryID, 
           fk_charity_AttendeeDetail_CreatedByID, 
           fk_charity_AttendeeDetail_UpdatedByID, 
           uq_charity_AttendeeDetail_BeneficiaryID, 
       } 


 #endregion 




 #region Properties 

       private static readonly List<IDBTableDefinitionPlugIn.ForeignKeyDefinition> ForeignKeys;                  

       public override string TableName => TABLE_NAME;
       private static readonly Dictionary<string, DataColumnDefinition> ColumnDefns; 

       public static readonly DataColumnDefinition defID;
       public static readonly DataColumnDefinition defCenterVisitationID;
       public static readonly DataColumnDefinition defBeneficiaryID;
       public static readonly DataColumnDefinition defIsPresent;
       public static readonly DataColumnDefinition defPictureStoredPath;
       public static readonly DataColumnDefinition defEducation;
       public static readonly DataColumnDefinition defEmotion;
       public static readonly DataColumnDefinition defHealth;
       public static readonly DataColumnDefinition defSpiritual;
       public static readonly DataColumnDefinition defSocial;
       public static readonly DataColumnDefinition defTalent;
       public static readonly DataColumnDefinition defObservations;
       public static readonly DataColumnDefinition defChristSmilesFeedBack;
       public static readonly DataColumnDefinition defCreatedAt;
       public static readonly DataColumnDefinition defUpdatedAt;
       public static readonly DataColumnDefinition defCreatedByID;
       public static readonly DataColumnDefinition defUpdatedByID;

       public int CenterVisitationID { get => (int)TargettedRow.GetDBValueConverted<int>(TableColumnNames.CenterVisitationID.ToString());  set => TargettedRow[TableColumnNames.CenterVisitationID.ToString()] = value; }


       public int BeneficiaryID { get => (int)TargettedRow.GetDBValueConverted<int>(TableColumnNames.BeneficiaryID.ToString());  set => TargettedRow[TableColumnNames.BeneficiaryID.ToString()] = value; }


       public bool IsPresent { get => (bool)TargettedRow.GetDBValueConverted<bool>(TableColumnNames.IsPresent.ToString());  set => TargettedRow[TableColumnNames.IsPresent.ToString()] = value; }


       public string PictureStoredPath { get => (string)TargettedRow.GetDBValueConverted<string>(TableColumnNames.PictureStoredPath.ToString());  set => TargettedRow[TableColumnNames.PictureStoredPath.ToString()] = value; }


       public string Education { get => (string)TargettedRow.GetDBValueConverted<string>(TableColumnNames.Education.ToString());  set => TargettedRow[TableColumnNames.Education.ToString()] = value; }


       public string Emotion { get => (string)TargettedRow.GetDBValueConverted<string>(TableColumnNames.Emotion.ToString());  set => TargettedRow[TableColumnNames.Emotion.ToString()] = value; }


       public string Health { get => (string)TargettedRow.GetDBValueConverted<string>(TableColumnNames.Health.ToString());  set => TargettedRow[TableColumnNames.Health.ToString()] = value; }


       public string Spiritual { get => (string)TargettedRow.GetDBValueConverted<string>(TableColumnNames.Spiritual.ToString());  set => TargettedRow[TableColumnNames.Spiritual.ToString()] = value; }


       public string Social { get => (string)TargettedRow.GetDBValueConverted<string>(TableColumnNames.Social.ToString());  set => TargettedRow[TableColumnNames.Social.ToString()] = value; }


       public string Talent { get => (string)TargettedRow.GetDBValueConverted<string>(TableColumnNames.Talent.ToString());  set => TargettedRow[TableColumnNames.Talent.ToString()] = value; }


       public string Observations { get => (string)TargettedRow.GetDBValueConverted<string>(TableColumnNames.Observations.ToString());  set => TargettedRow[TableColumnNames.Observations.ToString()] = value; }


       public string ChristSmilesFeedBack { get => (string)TargettedRow.GetDBValueConverted<string>(TableColumnNames.ChristSmilesFeedBack.ToString());  set => TargettedRow[TableColumnNames.ChristSmilesFeedBack.ToString()] = value; }


       public DateTime CreatedAt { get => (DateTime)TargettedRow.GetDBValueConverted<DateTime>(TableColumnNames.CreatedAt.ToString());  set => TargettedRow[TableColumnNames.CreatedAt.ToString()] = value; }


       public DateTime UpdatedAt { get => (DateTime)TargettedRow.GetDBValueConverted<DateTime>(TableColumnNames.UpdatedAt.ToString());  set => TargettedRow[TableColumnNames.UpdatedAt.ToString()] = value; }


       public int CreatedByID { get => (int)TargettedRow.GetDBValueConverted<int>(TableColumnNames.CreatedByID.ToString());  set => TargettedRow[TableColumnNames.CreatedByID.ToString()] = value; }


       public int UpdatedByID { get => (int)TargettedRow.GetDBValueConverted<int>(TableColumnNames.UpdatedByID.ToString());  set => TargettedRow[TableColumnNames.UpdatedByID.ToString()] = value; }


 #endregion

 #region Methods                                                      
                                                      
                                                                        
        /// <summary>                                                                                                             
        /// Returns null on failure                                                                                                             
        /// </summary>                                                                                                             
        /// <returns></returns>                                                                                                             
        /// <remarks></remarks>                                                                        
        public T___AttendeeDetail GetFirstRow()                                                                        
        {                                                                        
            if (this.HasRows())                                                                        
                return new (AllRows.First());                                                                        
            return null;                                                                        
        }                                                                        
                                                                        
        public static T___AttendeeDetail GetFullTable(DBTransaction transaction = null) =>                   
            TransactionRunner.InvokeRun( (conn) =>                  
                new T___AttendeeDetail(conn.Fetch(AttendeeDetail__ALL_COLUMNS___SQL_FILL_QUERY).FirstTable()),                  
                transaction                  
                );                                                      
                                                      
        public static T___AttendeeDetail GetRowWhereIDUsingSQL(long pID, DBTransaction transaction = null)                                                                        
        {                  
            return TransactionRunner.InvokeRun(                  
                (conn) =>                   
                new T___AttendeeDetail( conn.Fetch($"SELECT * FROM {TABLE_NAME} WHERE ID={pID}" ).FirstTable(), pID ),                  
                transaction                  
                );                  
        }                                                                        
                                                                        
        public T___AttendeeDetail GetRowWhereID(long pID) => new(this.RawTable, pID);                                                      
                                                      
        public Dictionary<string, DataColumnDefinition> GetDefinitions() => ColumnDefns;                                             
                                            
                                    
                  
        public virtual string GetFillSQL() => AttendeeDetail__NO__BINARY___SQL_FILL_QUERY;
                  
                  
        public List<IDBTableDefinitionPlugIn.ForeignKeyDefinition> GetForeignKeys() => ForeignKeys;                  
                  
        public string GetTableName() => TableName;

                  
                  
 #endregion                  
                  
                  

        #region Update Builder                  
                  
        public class UpdateQueryBuilder                  
        {                  
            private DataColumnParameter ParamID { get; }                  
            private DataColumnParameter ParamCenterVisitationID;
            private DataColumnParameter ParamBeneficiaryID;
            private DataColumnParameter ParamIsPresent;
            private DataColumnParameter ParamPictureStoredPath;
            private DataColumnParameter ParamEducation;
            private DataColumnParameter ParamEmotion;
            private DataColumnParameter ParamHealth;
            private DataColumnParameter ParamSpiritual;
            private DataColumnParameter ParamSocial;
            private DataColumnParameter ParamTalent;
            private DataColumnParameter ParamObservations;
            private DataColumnParameter ParamChristSmilesFeedBack;
            private DataColumnParameter ParamCreatedAt;
            private DataColumnParameter ParamUpdatedAt;
            private DataColumnParameter ParamCreatedByID;
            private DataColumnParameter ParamUpdatedByID;

                  
            public UpdateQueryBuilder(long ID)                  
            {                  
                ParamID = new(defID, ID);                  
            }                  

            public UpdateQueryBuilder( T___AttendeeDetail v):this(v.ID)                  
            {                  

                ParamCenterVisitationID = new(defCenterVisitationID, v.CenterVisitationID);                  
                ParamBeneficiaryID = new(defBeneficiaryID, v.BeneficiaryID);                  
                ParamIsPresent = new(defIsPresent, v.IsPresent);                  
                ParamPictureStoredPath = new(defPictureStoredPath, v.PictureStoredPath);                  
                ParamEducation = new(defEducation, v.Education);                  
                ParamEmotion = new(defEmotion, v.Emotion);                  
                ParamHealth = new(defHealth, v.Health);                  
                ParamSpiritual = new(defSpiritual, v.Spiritual);                  
                ParamSocial = new(defSocial, v.Social);                  
                ParamTalent = new(defTalent, v.Talent);                  
                ParamObservations = new(defObservations, v.Observations);                  
                ParamChristSmilesFeedBack = new(defChristSmilesFeedBack, v.ChristSmilesFeedBack);                  
                ParamCreatedAt = new(defCreatedAt, v.CreatedAt);                  
                ParamUpdatedAt = new(defUpdatedAt, v.UpdatedAt);                  
                ParamCreatedByID = new(defCreatedByID, v.CreatedByID);                  
                ParamUpdatedByID = new(defUpdatedByID, v.UpdatedByID);                  
            }                  
                  
            public UpdateQueryBuilder SetCenterVisitationID(int v)                  
            {                  
                ParamCenterVisitationID = new(defCenterVisitationID, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetBeneficiaryID(int v)                  
            {                  
                ParamBeneficiaryID = new(defBeneficiaryID, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetIsPresent(bool v)                  
            {                  
                ParamIsPresent = new(defIsPresent, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetPictureStoredPath(string v)                  
            {                  
                ParamPictureStoredPath = new(defPictureStoredPath, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetEducation(string v)                  
            {                  
                ParamEducation = new(defEducation, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetEmotion(string v)                  
            {                  
                ParamEmotion = new(defEmotion, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetHealth(string v)                  
            {                  
                ParamHealth = new(defHealth, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetSpiritual(string v)                  
            {                  
                ParamSpiritual = new(defSpiritual, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetSocial(string v)                  
            {                  
                ParamSocial = new(defSocial, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetTalent(string v)                  
            {                  
                ParamTalent = new(defTalent, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetObservations(string v)                  
            {                  
                ParamObservations = new(defObservations, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetChristSmilesFeedBack(string v)                  
            {                  
                ParamChristSmilesFeedBack = new(defChristSmilesFeedBack, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetCreatedAt(DateTime v)                  
            {                  
                ParamCreatedAt = new(defCreatedAt, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetUpdatedAt(DateTime v)                  
            {                  
                ParamUpdatedAt = new(defUpdatedAt, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetCreatedByID(int v)                  
            {                  
                ParamCreatedByID = new(defCreatedByID, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetUpdatedByID(int v)                  
            {                  
                ParamUpdatedByID = new(defUpdatedByID, v);                  
                return this;                  
            }                  

                  
            public string BuildSQL()                  
            {                  
                if (!this.CanUpdate()) throw new InvalidOperationException("Please, set at least a parameter to update.");                  
                  
                var p = this.GetTouchedColumns();                  
                System.Text.StringBuilder builder = new System.Text.StringBuilder($"UPDATE {TABLE_NAME} SET ");                  
                  
                foreach (var v in p) builder.Append($"{v.ColumnDefinition.ColumnName}={v.GetSQLValue()},");                  
                  
                builder = new System.Text.StringBuilder(builder.ToString().TrimEnd(','));                  
                builder.Append($" WHERE ID={ParamID.GetSQLValue()}");                  
                  
                return builder.ToString();                  
            }                  
                  
            public bool CanUpdate() => GetTouchedColumns().Count > 0;                  
                  
            private List<DataColumnParameter> GetTouchedColumns()                  
            {                  
                return this.GetType().GetFields(System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance)                  
                    .Where(x => x.GetValue(this) is DataColumnParameter)                  
                    .Select(x => (DataColumnParameter)x.GetValue(this))                  
                    .Where(x => !x.Equals(ParamID))                  
                    .ToList();                  
            }                  
                  
            public int Execute(DBTransaction trans = null)                  
            {                  
                return TransactionRunner.InvokeRun((conn) => conn.ExecuteTransactionQuery(this.BuildSQL()), trans);                  
            }                  
        }                  
                  
        #endregion                  
                  





        /// <summary> 
        /// You can not save image with this method 
        /// </summary> 
        /// <returns>Boolean</returns> 
        /// <remarks></remarks> 
        public static long InsertGetID(
            int CenterVisitationID,
            int BeneficiaryID,
            bool IsPresent,
            DateTime CreatedAt,
            DateTime UpdatedAt,
            int CreatedByID,
            int UpdatedByID,
            string PictureStoredPath = null,
            string Education = null,
            string Emotion = null,
            string Health = null,
            string Spiritual = null,
            string Social = null,
            string Talent = null,
            string Observations = null,
            string ChristSmilesFeedBack = null,
            DBTransaction transaction = null
          ){

                DataColumnParameter paramCenterVisitationID = new (defCenterVisitationID, CenterVisitationID);
                DataColumnParameter paramBeneficiaryID = new (defBeneficiaryID, BeneficiaryID);
                DataColumnParameter paramIsPresent = new (defIsPresent, IsPresent);
                DataColumnParameter paramPictureStoredPath = new (defPictureStoredPath, PictureStoredPath);
                DataColumnParameter paramEducation = new (defEducation, Education);
                DataColumnParameter paramEmotion = new (defEmotion, Emotion);
                DataColumnParameter paramHealth = new (defHealth, Health);
                DataColumnParameter paramSpiritual = new (defSpiritual, Spiritual);
                DataColumnParameter paramSocial = new (defSocial, Social);
                DataColumnParameter paramTalent = new (defTalent, Talent);
                DataColumnParameter paramObservations = new (defObservations, Observations);
                DataColumnParameter paramChristSmilesFeedBack = new (defChristSmilesFeedBack, ChristSmilesFeedBack);
                DataColumnParameter paramCreatedAt = new (defCreatedAt, CreatedAt);
                DataColumnParameter paramUpdatedAt = new (defUpdatedAt, UpdatedAt);
                DataColumnParameter paramCreatedByID = new (defCreatedByID, CreatedByID);
                DataColumnParameter paramUpdatedByID = new (defUpdatedByID, UpdatedByID);

                  
                  
            using var r = new TransactionRunner(transaction);                  
                  
            return r.Run( (conn) =>                   
            {                   
                      conn.ExecuteTransactionQuery(                  
                    string.Format(" INSERT INTO {0}([CenterVisitationID],[BeneficiaryID],[IsPresent],[PictureStoredPath],[Education],[Emotion],[Health],[Spiritual],[Social],[Talent],[Observations],[ChristSmilesFeedBack],[CreatedAt],[UpdatedAt],[CreatedByID],[UpdatedByID]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14},{15},{16})  ", TABLE_NAME,
                        paramCenterVisitationID.GetSQLValue(),
                        paramBeneficiaryID.GetSQLValue(),
                        paramIsPresent.GetSQLValue(),
                        paramPictureStoredPath.GetSQLValue(),
                        paramEducation.GetSQLValue(),
                        paramEmotion.GetSQLValue(),
                        paramHealth.GetSQLValue(),
                        paramSpiritual.GetSQLValue(),
                        paramSocial.GetSQLValue(),
                        paramTalent.GetSQLValue(),
                        paramObservations.GetSQLValue(),
                        paramChristSmilesFeedBack.GetSQLValue(),
                        paramCreatedAt.GetSQLValue(),
                        paramUpdatedAt.GetSQLValue(),
                        paramCreatedByID.GetSQLValue(),
                        paramUpdatedByID.GetSQLValue()                        )
                    );
                         
                return conn.GetScopeIdentity().ToLong();
            });

        }                  


        /// <summary> 
        /// You can not save image with this method 
        /// </summary> 
        /// <returns>Boolean</returns> 
        /// <remarks></remarks> 
        public static bool AddWithID(
            int ID,
            int CenterVisitationID,
            int BeneficiaryID,
            bool IsPresent,
            DateTime CreatedAt,
            DateTime UpdatedAt,
            int CreatedByID,
            int UpdatedByID,
            string PictureStoredPath = null,
            string Education = null,
            string Emotion = null,
            string Health = null,
            string Spiritual = null,
            string Social = null,
            string Talent = null,
            string Observations = null,
            string ChristSmilesFeedBack = null,
            DBTransaction transaction = null
          ){

                DataColumnParameter paramID = new (defID, ID);
                DataColumnParameter paramCenterVisitationID = new (defCenterVisitationID, CenterVisitationID);
                DataColumnParameter paramBeneficiaryID = new (defBeneficiaryID, BeneficiaryID);
                DataColumnParameter paramIsPresent = new (defIsPresent, IsPresent);
                DataColumnParameter paramPictureStoredPath = new (defPictureStoredPath, PictureStoredPath);
                DataColumnParameter paramEducation = new (defEducation, Education);
                DataColumnParameter paramEmotion = new (defEmotion, Emotion);
                DataColumnParameter paramHealth = new (defHealth, Health);
                DataColumnParameter paramSpiritual = new (defSpiritual, Spiritual);
                DataColumnParameter paramSocial = new (defSocial, Social);
                DataColumnParameter paramTalent = new (defTalent, Talent);
                DataColumnParameter paramObservations = new (defObservations, Observations);
                DataColumnParameter paramChristSmilesFeedBack = new (defChristSmilesFeedBack, ChristSmilesFeedBack);
                DataColumnParameter paramCreatedAt = new (defCreatedAt, CreatedAt);
                DataColumnParameter paramUpdatedAt = new (defUpdatedAt, UpdatedAt);
                DataColumnParameter paramCreatedByID = new (defCreatedByID, CreatedByID);
                DataColumnParameter paramUpdatedByID = new (defUpdatedByID, UpdatedByID);

                  
                  
            using var r = new TransactionRunner(transaction);                  
                  
            return r.Run( (conn) =>                   
                      conn.ExecuteTransactionQuery(                  
                    string.Format(" SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[CenterVisitationID],[BeneficiaryID],[IsPresent],[PictureStoredPath],[Education],[Emotion],[Health],[Spiritual],[Social],[Talent],[Observations],[ChristSmilesFeedBack],[CreatedAt],[UpdatedAt],[CreatedByID],[UpdatedByID]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14},{15},{16},{17})  SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,
                        paramID.GetSQLValue(),
                        paramCenterVisitationID.GetSQLValue(),
                        paramBeneficiaryID.GetSQLValue(),
                        paramIsPresent.GetSQLValue(),
                        paramPictureStoredPath.GetSQLValue(),
                        paramEducation.GetSQLValue(),
                        paramEmotion.GetSQLValue(),
                        paramHealth.GetSQLValue(),
                        paramSpiritual.GetSQLValue(),
                        paramSocial.GetSQLValue(),
                        paramTalent.GetSQLValue(),
                        paramObservations.GetSQLValue(),
                        paramChristSmilesFeedBack.GetSQLValue(),
                        paramCreatedAt.GetSQLValue(),
                        paramUpdatedAt.GetSQLValue(),
                        paramCreatedByID.GetSQLValue(),
                        paramUpdatedByID.GetSQLValue()                        )
                    ).ToBoolean() 
               );
        }                  


        /// <summary> 
        /// You can not save image with this method 
        /// </summary> 
        /// <returns>Boolean</returns> 
        /// <remarks></remarks> 
        public static bool Add(
            int CenterVisitationID,
            int BeneficiaryID,
            bool IsPresent,
            DateTime CreatedAt,
            DateTime UpdatedAt,
            int CreatedByID,
            int UpdatedByID,
            string PictureStoredPath = null,
            string Education = null,
            string Emotion = null,
            string Health = null,
            string Spiritual = null,
            string Social = null,
            string Talent = null,
            string Observations = null,
            string ChristSmilesFeedBack = null,
            DBTransaction transaction = null
          ){

                DataColumnParameter paramCenterVisitationID = new (defCenterVisitationID, CenterVisitationID);
                DataColumnParameter paramBeneficiaryID = new (defBeneficiaryID, BeneficiaryID);
                DataColumnParameter paramIsPresent = new (defIsPresent, IsPresent);
                DataColumnParameter paramPictureStoredPath = new (defPictureStoredPath, PictureStoredPath);
                DataColumnParameter paramEducation = new (defEducation, Education);
                DataColumnParameter paramEmotion = new (defEmotion, Emotion);
                DataColumnParameter paramHealth = new (defHealth, Health);
                DataColumnParameter paramSpiritual = new (defSpiritual, Spiritual);
                DataColumnParameter paramSocial = new (defSocial, Social);
                DataColumnParameter paramTalent = new (defTalent, Talent);
                DataColumnParameter paramObservations = new (defObservations, Observations);
                DataColumnParameter paramChristSmilesFeedBack = new (defChristSmilesFeedBack, ChristSmilesFeedBack);
                DataColumnParameter paramCreatedAt = new (defCreatedAt, CreatedAt);
                DataColumnParameter paramUpdatedAt = new (defUpdatedAt, UpdatedAt);
                DataColumnParameter paramCreatedByID = new (defCreatedByID, CreatedByID);
                DataColumnParameter paramUpdatedByID = new (defUpdatedByID, UpdatedByID);

                  
                  
            using var r = new TransactionRunner(transaction);                  
                  
            return r.Run( (conn) => conn.ExecuteTransactionQuery(                  
                    string.Format(" INSERT INTO {0}([CenterVisitationID],[BeneficiaryID],[IsPresent],[PictureStoredPath],[Education],[Emotion],[Health],[Spiritual],[Social],[Talent],[Observations],[ChristSmilesFeedBack],[CreatedAt],[UpdatedAt],[CreatedByID],[UpdatedByID]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14},{15},{16})  ", TABLE_NAME,
                        paramCenterVisitationID.GetSQLValue(),
                        paramBeneficiaryID.GetSQLValue(),
                        paramIsPresent.GetSQLValue(),
                        paramPictureStoredPath.GetSQLValue(),
                        paramEducation.GetSQLValue(),
                        paramEmotion.GetSQLValue(),
                        paramHealth.GetSQLValue(),
                        paramSpiritual.GetSQLValue(),
                        paramSocial.GetSQLValue(),
                        paramTalent.GetSQLValue(),
                        paramObservations.GetSQLValue(),
                        paramChristSmilesFeedBack.GetSQLValue(),
                        paramCreatedAt.GetSQLValue(),
                        paramUpdatedAt.GetSQLValue(),
                        paramCreatedByID.GetSQLValue(),
                        paramUpdatedByID.GetSQLValue()                            
                            )
                        ).ToBoolean()
                    );


        }                  


                  
        /// <summary>                  
        /// Update current table. Works just for Target Row                  
        /// </summary>                  
        /// <param name="reloadTable">if you want this class reloaded</param>                  
        /// <param name="transaction"></param>                  
        /// <returns></returns>                  
        public bool Update(bool reloadTable = false, DBTransaction transaction = null)                  
        {                  
            return TransactionRunner.InvokeRun(                  
               (conn) => {                  
                   bool r = new UpdateQueryBuilder(this).Execute(conn).ToBoolean();                  
                   if (reloadTable) this.LoadFromRows( GetRowWhereIDUsingSQL(this.ID, conn).TargettedRow );                  
                   return r;                  
               },                  
               transaction                  
               );                  
        }                  
                  



                  
                  
        /// <summary>                  
        /// Deletes with an option to pass in transaction                  
        /// </summary>                  
        /// <returns></returns>                  
        /// <remarks></remarks>                  
        public bool DeleteRow(DBTransaction transaction = null)                  
        {                  
            return DeleteItemRow(ID, transaction);                  
        }                  
                  
        public static bool DeleteItemRow(long pID, DBTransaction transaction = null)                                                      
        {                  
            return TransactionRunner.InvokeRun(                  
               (conn) => conn.ExecuteTransactionQuery($"DELETE FROM {TABLE_NAME} WHERE ID={pID} ").ToBoolean(),                  
               transaction                  
               );                  
        }                  



   }


}
