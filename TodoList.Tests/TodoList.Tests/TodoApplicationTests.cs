namespace TodoList.Tests
{
    public class TodoApplicationTests
    {
        [Fact]
        public void Todo_List_Exists()
        {
            var todoList = new TodoList();
            Assert.NotNull(todoList);
        }

        [Fact]
        public void Can_Get_Todos()
        {
            var todoList = new TodoList();
            var result = todoList.Todos;
            Assert.NotNull(result);
            Assert.Empty(result);
            Assert.IsAssignableFrom<IEnumerable<Todo>>(result);

        }

        [Fact]
        public void Can_Add_Todo()
        {
            var todo = new Todo() {  Description="A Todo Item"};
            TodoList todoList = new TodoList();
            todoList.AddTodo(todo);
            Assert.Single<Todo>(todoList.Todos);
        }

        [Fact]
        public void On_Null_Argument_Error_Occurs()
        {
            var todoList = new TodoList();
            Todo todo = null;

            var exception = Record.Exception(() => todoList.AddTodo(todo));

            //Act
            //todoList.AddTodo(todo);
            Assert.IsType<ArgumentNullException>(exception);

        }

        [Fact]
        public void OnNullAndDescriptionRequiredValidationErrorOccurs()
        {
            var todoList = new TodoList();
            Todo todo = new Todo { Description = null };

            var exception = Record.Exception(() => todoList.AddTodo(todo));
            Assert.NotNull(exception);
            Assert.IsType<DescriptionRequiredException>(exception);


        }



    }


    public class TodoModelTests
    {
        [Fact]
        public void ItHasDescription()
        {
            var todo = new Todo();
            todo.Description = "Test Desciption";

        }
        [Fact(Skip = "Validate generated")]
        public void ItHasOwnValidate()
        {
            var todo = new Todo();
            //todo.

            todo.Validate();
        }

        [Fact]
        public void DescriptionRequiredValidationOnTodoItemValidate()
        {
            var todo = new Todo() { Description = null };
            var exception = Record.Exception(() => todo.Validate());

            Assert.NotNull(exception);
            Assert.IsType<DescriptionRequiredException>(exception);

        }


    }
    public class Todo
    {
        public string Description { get; internal set; }

        public void Validate()
        {
            Description = Description ?? throw new DescriptionRequiredException();
        }
    }




    public class TodoList
    {

        public List<Todo> Todos { get; } = new List<Todo>();

        internal void AddTodo(Todo todo)
        {
            todo = todo ?? throw new ArgumentNullException(nameof(todo));
            todo.Validate();

            Todos.Add(todo);

        }
    }

    public class DescriptionRequiredException : Exception
    {

    }
}

