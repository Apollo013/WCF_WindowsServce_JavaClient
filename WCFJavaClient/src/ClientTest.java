import org.tempuri.*;

public class ClientTest {

	public static void main(String[] args) {
		try{
			CalculatorService client = new CalculatorService();
			ICalculator port = client.getBasicHttpBindingICalculator();
			
			double total = port.add(45.88, 23.55);
			System.out.println("45.88 + 23.55 = " + total);
			
			total = port.divide(500.00, 20.00);
			System.out.println("500.00 / 20.00 = " + total);
						
			total = port.multiply(50.00, 20.00);
			System.out.println("50.00 * 20.00 = " + total);
			
			total = port.subtract(50.00, 20.00);
			System.out.println("50.00 - 20.00 = " + total);			
		}
		catch(Exception ex){
			ex.printStackTrace();
		}
	}
}
