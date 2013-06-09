using System.Windows;
using TodoWpf.ViewModel;
using Xunit;

namespace TodoWpf.Tests.ViewModel
{
    public class TodoItemTests
    {
        [Fact]
        public void CompleteRecordShouldBeGray()
        {
            var todoItem = new TodoItemViewModel
            {
                Complete = true
            };

            Assert.Equal("#BBBBBB", todoItem.ContentColor);
        }

        [Fact]
        public void IncompleteRecordShouldBeBlack()
        {
            var todoItem = new TodoItemViewModel
            {
                Complete = false
            };

            Assert.Equal("#000000", todoItem.ContentColor);
        }

        [Fact]
        public void ClickingLabelShouldPutViewModelInEditMode()
        {
            var todoItem = new TodoItemViewModel
            {
                EditMode = false
            };

            todoItem.LabelClickedCommand.Execute(new {});

            Assert.True(todoItem.EditMode);
        }

        [Fact]
        public void TextboxShouldBeVisibleWhenInEditMode()
        {
            var todoItem = new TodoItemViewModel
            {
                EditMode = true
            };

            Assert.Equal(Visibility.Visible, todoItem.TextboxVisibility);
        }

        [Fact]
        public void LabelShouldBeHiddenWhenInEditMode()
        {
            var todoItem = new TodoItemViewModel
            {
                EditMode = true
            };

            Assert.Equal(Visibility.Hidden, todoItem.LabelVisibility);
        }

        [Fact]
        public void TexboxShouldBeHiddenWhenNotInEditMode()
        {
            var todoItem = new TodoItemViewModel
            {
                EditMode = false
            };

            Assert.Equal(Visibility.Hidden, todoItem.TextboxVisibility);
        }

        [Fact]
        public void LabelShouldBeVisibleWhenNotInEditMode()
        {
            var todoItem = new TodoItemViewModel
            {
                EditMode = false
            };

            Assert.Equal(Visibility.Visible, todoItem.LabelVisibility);
        }

        [Fact]
        public void LabelShouldBeShownByDefault()
        {
            var todoItem = new TodoItemViewModel();
            Assert.Equal(Visibility.Visible, todoItem.LabelVisibility);
        }

        [Fact]
        public void TextboxShouldBeHiddenByDefault()
        {
            var todoItem = new TodoItemViewModel();
            Assert.Equal(Visibility.Hidden, todoItem.TextboxVisibility);
        }

        [Fact]
        public void EnterKeyShouldEndEditMode()
        {
            var todoItem = new TodoItemViewModel
            {
                EditMode = true
            };

            todoItem.EnterKeyCommand.Execute(new {});

            Assert.False(todoItem.EditMode);
        }
    }
}
