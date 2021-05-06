# Důležité hodnoty
```C#
/* Připojení k databázi (Data Source: Server ze kterého vybíráme;
* Initial Catalog: Název databáze;User ID a Password: přihlašovací údaje k serveru
*/
const string connetionString = @"Data Source=server.tech;Initial Catalog=Databaze;User ID=User;Password=Password123";
String sql = ""; //zde se uloží SQL příkaz
SqlConnection cnn; // Vytváří připojení do databáze
```
# Důležitý kód
## Spuštění dotazu
- Kód, který provede dotaz

```C#
void SQLDotaz(String Dotaz)
{
  DataTable dtbl = new DataTable();
  SqlDataAdapter sda = new SqlDataAdapter(Dotaz,cnn); // Předání dotazu
  sda.Fill(dtbl); //Získaná data naplní do DataTable
  dataGridView1.DataSource = dtbl; //Přiřazení dat do dataGridView
}
```
# Syntax dotazů
## Výběrový dotaz
```SQL
SELECT * FROM TABLE WHERE PODMINKA;
SELECT * FROM ZAMESTANCI WHERE ID = 1;
```
## Aktualizační dotaz
```SQL
UPDATE TABLE
SET POLE = HODNOTA, POLE2 = HODNOTA2
WHERE PODMINKA;

UPDATE Customers
SET ContactName = 'Alfred Schmidt', City= 'Frankfurt'
WHERE CustomerID = 1;
```
## Mazací dotaz
```SQL
DELETE FROM TABLE WHERE PODMINKA
DELETE FROM ZAMESTANCI WHERE PRACE = "IT"
```
