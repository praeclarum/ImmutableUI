using System;

using Xamarin.Forms;
using InterpretedUI.Forms;

namespace FormsButtonCounter
{
    public class MainPage : ContentPage
    {
        public MainPage() => Content = BuildView().CreateView();

        void SetState() => BuildView().Apply(Content);

        int _counter;

        Command _push => new Command(() =>
        {
            _counter++;
            SetState();
        });

        ViewModel BuildView()
        {
            return new StackLayoutModel(
                children: new ViewModel[] {
                    new LabelModel (text: _counter.ToString(), fontSize: 42),
                    new ButtonModel (text: "Increment", command: _push),
                },
                padding: new Thickness (42));
        }
    }
}

