# C#
```C#
DataTable dt = new DataTable();

resultTextBox.text = dt.Compute(inputTextBox.Text, "").toString();
```

# Java
```Java
Double result = null;
ScriptEngine engine = new ScriptEngineManager().getEngineByName("rhino");

try {
        result = (double)engine.eval(formula);
        } catch (ScriptException e)
        {
            Toast.makeText(this, "Invalid Input", Toast.LENGTH_SHORT).show();
        }

        if(result != null)
            resultsTV.setText(String.valueOf(result.doubleValue()));
```
## Build gradle
implementation 'io.apisense:rhino-android:1.0'


https://www.youtube.com/watch?v=kqmSUwRZ6kg
