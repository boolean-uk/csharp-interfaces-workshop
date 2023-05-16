using workshop.serviceexample;
using workshop.serviceexample.Interface;
using workshop.serviceexample.Providers;

IDatabaseProvider dbProvider = new AmazonDBService();



DatabaseAccessLayer db = new DatabaseAccessLayer(dbProvider);

db.DeleteRecordsFromProvider();
db.UpdateRecordsFromProvider();
db.SelectRecordsFromProvider();