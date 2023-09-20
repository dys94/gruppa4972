//Ввести номер четверти
//Ответить на вопрос
//Вывести ответ

string QuterBorderAsk (int numQut)
{
    if(numQut  == 1) return "x > 0, y > 0";
    if(numQut  == 2) return "x > 0, y < 0";
    if(numQut  == 3) return "x < 0, y < 0";
    if(numQut  == 4) return "x < 0, y > 0";
    return string.Empty;
}
