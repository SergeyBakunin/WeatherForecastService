namespace WeatherForecastService.Models
{

    /// <summary>
    /// Объект на базе класса WeatherForecastHolder, будет хранить список показателей температуры
    /// </summary>
    public class WeatherForecastHolder
    {
        // Коллекция для хранения показателей температуры
        private List<WeatherForecast> _values;

        #region Конструкторы

        public WeatherForecastHolder()
        {
            // Инициализирую коллекцию для хранения показателей температуры
            _values = new List<WeatherForecast>();
        }

        #endregion

        /// <summary>
        /// Добавить новый показатель температуры
        /// </summary>
        /// <param name="date"> Дата фиксации температуры </param>
        /// <param name="temperatureC"> Показатель температуры </param>
        public void Add(DateTime date, int temperatureC)
        {
            _values.Add(new WeatherForecast() { Date = date, TemperatureC = temperatureC });
        }

        /// <summary>
        /// Обновить показатель температуры
        /// </summary>
        /// <param name="date"> Дата фиксации температуры </param>
        /// <param name="temperatureC"> Новый показатель температуры </param>
        /// <returns> Результат выполнения операции </returns>
        public bool Update(DateTime date, int temperatureC)
        {
            foreach (var item in _values)
            {
                if (item.Date == date)
                    item.TemperatureC = temperatureC;
                return true;
            }
            return false;
        }

        /// <summary>
        /// Получить показатели температуры за временной период
        /// </summary>
        /// <param name="dateFrom"> Начальная дата </param>
        /// <param name="dateTo"> Конечная дата </param>
        /// <returns> Коллекция показателей температуры </returns>
        public List<WeatherForecast> Get(DateTime dateFrom, DateTime dateTo)
        {
            return _values.FindAll(item => item.Date >= dateFrom && item.Date <= dateTo);
        }

        /// <summary>
        /// Удалить показатель температуры за дату
        /// </summary>
        /// <param name="date"> Дата фиксации показателя температуры </param>
        /// <returns> Результат выполнения операции </returns>
        public bool Delete(DateTime date)
        {
            //TODO: доработать в рамках дз
            foreach (var item in _values)
            {
                Delete (item.Date);
                return true;
            }
            return false;
                        
        }
    }
}
