class ToDoList{
    public static string[] Tasks = new string[10];
    public static int taskCount = 0;
    public static void Add(){
        Console.WriteLine("Enter your task!");
        Tasks[taskCount] = Console.ReadLine();;
        taskCount ++;
        if(taskCount == 10){
            Console.WriteLine("you meet maximom tasks");
            return;
        }
        Console.WriteLine("Task number " + taskCount+ " " + Tasks[taskCount] + " added!"); 
    }
    public static void ViewTasks() {
        for(int i = 0; i < taskCount;i++) {
            Console.WriteLine((i+1)+ "- " + Tasks[i]);
        }

    }
    public static void CompleteTask(){
        Console.WriteLine("input task number");
        int indx = int.Parse(Console.ReadLine());
        Tasks[indx-1] = Tasks[indx-1] + " (Completed)";
    }

    public static void Main(string[] args)
    {
        Console.WriteLine("For add task type 1");
        Console.WriteLine("For veiw all tasks type 2");
        Console.WriteLine("For mark a task as completed type 3");
        Console.WriteLine("type -1 to exit");
        bool contiue = true;
        while(contiue){
            int option =int.Parse(Console.ReadLine());
            switch(option){
                case 1:
                    if(taskCount < 10){
                    Add();
                    }else {Console.WriteLine("you met the limit!");}
                break;
                case 2:
                    ViewTasks();
                break;  
                case 3:
                    CompleteTask();
                break;
                case -1:
                    contiue = false;
                break;
                default: 
                    Console.WriteLine("Write a valid input!");
                break;
            }
        }
    }
}