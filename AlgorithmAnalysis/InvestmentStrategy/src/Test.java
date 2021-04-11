import java.io.BufferedReader;
import java.io.File;
import java.io.FileReader;
import java.io.IOException;
import java.util.Scanner;

public class Test {
	
	static double investsTable[][] = new double[30][30];
	static double f1Table[] = new double[30];
	static double f2Table[] = new double[30];
	static double invests[][];
	static double f1[];
	static double f2[];
	public static void main(String[] args) {
		int investmentNumber,money,yearNumber,id;;
		parseFile();
		
		Scanner s = new Scanner(System.in);
		System.out.print("Number of the investments: ");
		investmentNumber = s.nextInt();
		System.out.println();
		System.out.print("Enter the amount of money you will invest: ");
		money = s.nextInt();
		System.out.println();
		System.out.print("How many years will you invest: ");
		yearNumber = s.nextInt();
		invests = new double[investmentNumber][yearNumber];
		for (int i = 0; i < investmentNumber; i++) {
			System.out.print("Enter the id of the "+ (i+1) +"th investment: ");
			id = s.nextInt();
			for (int j = 0; j < yearNumber; j++) {
				invests[i][j] = investsTable[id-1][j];
			}
			
		}
		
		f1 = new double[yearNumber];
		for (int i = 0; i < f1.length; i++) {
			f1[i] = f1Table[i];
		}
		f2 = new double[yearNumber];
		for (int i = 0; i < f2.length; i++) {
			f2[i] = f2Table[i];
		}
		
		System.out.println(culculateOptimalInvest(1,yearNumber, -1, (double)money));
		
		
	}
	
	public static double culculateOptimalInvest(int curYear,int year,int prevInvestIndex,double money){
		double q[] = new double[invests.length];
		if(year == 0){
			return money;
		}
		else{
			for (int i = 0; i < invests.length; i++) {
				q[i] = culculateOptimalInvest(curYear+1,year-1,i,moneyCulculator(curYear,money,i,prevInvestIndex));
			}
			double maxValue = max(q);
			return maxValue;
		}
	}
	
	public static double max(double[] a){
		
		double max=-1;
		for (int i = 0; i < a.length; i++) {
			if(max < a[i]){
				max = a[i];
			}
		}
		
		
		return max;
	}
	
	public static double moneyCulculator(int year,double m,int investIndex,int prevInvestIndex){
		
		double money;
		
		if(prevInvestIndex != -1){
			if(prevInvestIndex==investIndex){
				money = m + (m*invests[investIndex][year-1]/100);
				money = money  - (money*f1[prevInvestIndex]/100);
			}
			else{
				money = m + (m*invests[investIndex][year-1]/100);
				money = money - (money*f2[prevInvestIndex]/100);
			}
		}
		else{
			money = m + (m*invests[investIndex][year-1]/100);
		}
		
		return money;
	}
	
	public static void parseFile(){
		String words[];
		int flag = 0;
		int i=0;
		try {
			File file = new File("input.txt");
			FileReader fileReader = new FileReader(file);
			BufferedReader bufferedReader = new BufferedReader(fileReader);
			String line;
			while ((line = bufferedReader.readLine()) != null) {
				if(flag>1 && i<30){
					words = line.split(",");
					for (int j = 1; j < words.length-1; j++) {
						investsTable[i][j-1] = Double.parseDouble(words[j].substring(1, words[j].length()-1));
					}
					i++;
				}
				else if(flag==36){
					words = line.split(",");
					for (int j = 1; j < f1Table.length; j++) {
						f1Table[j-1] = Double.parseDouble(words[j].substring(1, words[j].length()-1));
					}
				}
				else if(flag==37){
					words = line.split(",");
					for (int j = 1; j < f2Table.length; j++) {
						f2Table[j-1] = Double.parseDouble(words[j].substring(1, words[j].length()-1));
					}
				}
				flag++;
			}
			fileReader.close();
			
		} catch (IOException e) {
			e.printStackTrace();
		}
	}
}
