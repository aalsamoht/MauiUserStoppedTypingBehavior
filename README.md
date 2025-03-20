# UserStoppedTypingBehavior

Current Behavior: The `Command` is *NOT* executed on the MainThread.
Expected Behavior: The `Command` is executed on the MainThread.

```xml
<SearchBar.Behaviors>
  <toolkit:UserStoppedTypingBehavior
    BindingContext="{Binding Path=BindingContext, Source={x:Reference UserStoppedTypingSearchBar}, x:DataType=SearchBar}"
    Command="{Binding SearchCommand, Mode=OneTime}"
    StoppedTypingTimeThreshold="750"
    ShouldDismissKeyboardAutomatically="False">
  </toolkit:UserStoppedTypingBehavior>
</SearchBar.Behaviors>
```
