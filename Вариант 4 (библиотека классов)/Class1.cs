//https://docs.google.com/document/d/1qZEaADy71rJCOuNSTpyhh-f-NhSL2a6DCm88EgFO20o/edit
namespace Вариант_4__библиотека_классов_
{
    public class Группа
    {
        private string название;
        private string сокращение;
        private int численность;
        private int год_поступления;
        private string ссылка_на_специальность;
        private string классный_руководитель;
        private string ссылка_на_сотрудника;

        public Группа(string название, string сокращение, int численность, string ссылка_на_специальность, string классный_руководитель, string ссылка_на_сотрудника, int год_поступления = -1)
        {
            this.название = название;
            this.сокращение = сокращение;
            this.численность = численность;
            this.ссылка_на_специальность = ссылка_на_специальность;
            this.классный_руководитель = классный_руководитель;
            this.ссылка_на_сотрудника = ссылка_на_сотрудника;
            if (год_поступления == -1)
            {
                this.год_поступления = DateTime.Now.Year;
            }
            else
            {
                this.год_поступления = год_поступления;
            }
        }
    }
}