public Order GetOrder(string id)
{
	var sql = "SELECT * FROM Orders WHERE Id = '" + id + "'";
	var order = db.Query(sql).First();
	return order;
}