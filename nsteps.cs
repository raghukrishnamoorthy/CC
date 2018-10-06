namespace CC
{
    public class CountSteps {

        public static int CountWays(int step) {
            if (step < 0) {
                return 0;
            }
            if(step == 0) {
                return 1;
            }    
            return CountWays(step - 1) + CountWays(step - 2) + CountWays(step - 3);
        }
    }
}