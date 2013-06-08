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
    }
}
