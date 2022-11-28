using System.Windows;

namespace MilionerzyWPF
{
    public class MainWindowVM : ViewModelBase
    {
        public MainWindowVM()
        {
            Content = content = menuControl;
            var cmdReturn = new Command(() => Content = menuControl);

            ((ReturnableBase)scoresControl  .DataContext).CmdReturn =
            ((ReturnableBase)settingsControl.DataContext).CmdReturn =
            ((ReturnableBase)gameControl    .DataContext).CmdReturn = cmdReturn;

            var vm = (MenuControlVM)menuControl.DataContext;
            vm.CmdSettings = new Command(() => Content = settingsControl);
            vm.CmdNewGame  = new Command(() => Content = gameControl    );
            vm.CmdScores   = new Command(() => Content = scoresControl  );
        }

        public UIElement Content {  get => content; set => Set(value, ref content); }
        private UIElement content;

        private readonly GameControl     gameControl     = new();
        private readonly ScoresControl   scoresControl   = new();
        private readonly SettingsControl settingsControl = new();
        private readonly MenuControl     menuControl     = new();
    }
}
