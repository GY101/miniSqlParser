
namespace MiniSqlParser
{
    public enum ExpOperator
    {
        StringConcat
      , Mult
      , Div
      , Mod
      , Add
      , Sub
      , LeftBitShift
      , RightBitShift
      , BitAnd
      , BitOr
      , GetJsonObj        // ->
      , GetJsonObjAsText  // ->>
      , GetJsonPath       // #>
      , GetJsonPathAsText // #>>
      , DelJsonObj        // #-
      , Less
      , LessOrEqual
      , Greater
      , GreaterOrEqual
      , Equal
      , Equal2
      , NotEqual
      , NotEqual2 
    }
}
