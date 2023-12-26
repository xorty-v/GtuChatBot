using GtuChatBot;

Task2();

void Task1()
{
    string[] userQuestions =
{
    "Как выявить старт учебных сессий и временной промежуток сдачи экзаменов?",
    "Как определить начало учебных периодов и период проведения экзаменов?",
    "Как узнать начало учебных семестров и временной интервал экзаменов?",
    "Что охватывает образовательная программа?",
    "Каков содержательный состав образовательной программы?",
    "Какие компоненты включает в себя образовательная программа?",
    "Kak uznat, kogda nachinayutsya uchebnye semestry i period ekzamenov?",
    "Kak uznat, kogda nachinayutsya uchebnye periody i sroki provedeniya ekzamenov?",
    "Kak opredelit nachalo uchebnykh semestrov i period sdachi ekzamenov?",
    "Как временно заморозить статус студента?",
    "Как остановить свой студенческий статус?",
    "Как приостановить свой статус учащегося?"
};

    Console.WriteLine("\t\t\t\t----------Вариации вопросов — процент понимания----------");


    foreach (var question in userQuestions)
    {

        var sampleData = new ChatQuestionModel.ModelInput()
        {
            Col0 = $"{question}",
        };

        //Load model and predict output
        var result = ChatQuestionModel.Predict(sampleData);

        Console.WriteLine($"\t{question} — {result.Score.Max() * 100}%");
    }
}

void Task2()
{
    while (true)
    {
        Console.Write("\nЗадайте вопрос: ");
        string userInput = Console.ReadLine();

        var sampleData = new ChatQuestionModel.ModelInput()
        {
            Col0 = $"{userInput}",
        };

        var result = ChatQuestionModel.Predict(sampleData);

        Console.WriteLine($"{userInput} — {result.Score.Max() * 100}%");

        Console.WriteLine($"\nОтвет: {result.PredictedLabel}");
    }
}