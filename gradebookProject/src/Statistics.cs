namespace src
{
    public class Statistics
    {
        public double SUM;
        public double High;
        public double Low;
        public double Avg; 
        public char Letter;
 
        public Statistics(){
            this.SUM=0.0;
            this.High=double.MinValue;
            this.Low=double.MaxValue;
            this.Avg=0.0;
            this.Letter=' ';
        }
    }
}