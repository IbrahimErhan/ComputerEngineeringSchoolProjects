public class Test {
	
	// Global Arrays
	private static int[] array;
    private static int[] tempMergArr;
    private static int length;
    
    // Main function to test sort times of each sort algorithm.
	public static void main(String[] args) {
		
		// Initial array size.
		int arraySizes =1000;
		
		// Calculation array.
		int arr[];
		
		long startTime=0;
		long stopTime=0;
		
		// Loop for increase array size 1000->10000->100000
		// To calculate elapsed time program uses nanosecond but I divide it 10000 to read
		// the values easily.
		
		for (int j = 0; j < 3; j++) {
			
			// Template arrays in random,equal,increasing,decreasing format. 
			int randomArray[] = new int[arraySizes];
			for (int i = 0; i < randomArray.length; i++) {
				randomArray[i] = ((int)(Math.random()*1000));
			}
			
			int constantArray[] = new int[arraySizes];
			int constant = ((int)(Math.random()*1000));
			for (int i = 0; i < constantArray.length; i++) {
				constantArray[i] = constant;
			}
			
			int increasingArray[] = new int[arraySizes];
			for (int i = 0; i < increasingArray.length; i++) {
				increasingArray[i] = i;
			}
			
			int decreasingArray[] = new int[arraySizes];
			for (int i = decreasingArray.length-1; i > -1; i--) {
				decreasingArray[i] = i;
			}
			
			arr= new int[arraySizes];
			
			System.out.println("\n"+"Array Size = "+arraySizes);
			
			System.out.println("\n"+"---------- Quick SortFirst Element ----------");
			System.out.println(">> Equal Integers");
			for (int i = 0; i < arr.length; i++) {
				arr[i] = constantArray[i];
			}
			
			int temp = arr[0];
			arr[0] = arr[arr.length-1];
			arr[arr.length-1] = temp;
			startTime = (int) System.nanoTime();
			//quickSort(arr,0,arr.length-1);
			stopTime = (int) System.nanoTime();
			System.out.println(Math.abs(stopTime-startTime)/10000);
			
			System.out.println(">> Random Integers");
			for (int i = 0; i < arr.length; i++) {
				arr[i] = randomArray[i];
			}
			
			temp = arr[0];
			arr[0] = arr[arr.length-1];
			arr[arr.length-1] = temp;
			startTime = (int) System.nanoTime();
			quickSort(arr,0,arr.length-1);
			stopTime = (int) System.nanoTime();
			System.out.println(Math.abs(stopTime-startTime)/10000);
			
			System.out.println(">> Increasing Integers");
			for (int i = 0; i < arr.length; i++) {
				arr[i] = increasingArray[i];
			}
			
			temp = arr[0];
			arr[0] = arr[arr.length-1];
			arr[arr.length-1] = temp;
			startTime = (int) System.nanoTime();
			quickSort(arr,0,arr.length-1);
			stopTime = (int) System.nanoTime();
			System.out.println(Math.abs(stopTime-startTime)/10000);
			
			System.out.println(">> Decreasing Integers");
			for (int i = 0; i < arr.length; i++) {
				arr[i] = decreasingArray[i];
			}
			
			temp = arr[0];
			arr[0] = arr[arr.length-1];
			arr[arr.length-1] = temp;
			startTime = (int) System.nanoTime();
			quickSort(arr,0,arr.length-1);
			stopTime = (int) System.nanoTime();
			System.out.println(Math.abs(stopTime-startTime)/10000);
			
			
			
			
			System.out.println("\n"+"---------- Quick Sort Middle Element ----------");
			
			
			
			System.out.println(">> Equal Integers");
			for (int i = 0; i < arr.length; i++) {
				arr[i] = constantArray[i];
			}
			
			temp = arr[(int)((arr.length-1)/2)];
			arr[(int)((arr.length-1)/2)] = arr[arr.length-1];
			arr[arr.length-1] = temp;
			startTime = (int) System.nanoTime();
			quickSort(arr,0,arr.length-1);
			stopTime = (int) System.nanoTime();
			System.out.println(Math.abs(stopTime-startTime)/10000);
			
			System.out.println(">> Random Integers");
			for (int i = 0; i < arr.length; i++) {
				arr[i] = randomArray[i];
			}
			
			temp = arr[(int)((arr.length-1)/2)];
			arr[(int)((arr.length-1)/2)] = arr[arr.length-1];
			arr[arr.length-1] = temp;
			startTime = (int) System.nanoTime();
			quickSort(arr,0,arr.length-1);
			stopTime = (int) System.nanoTime();
			System.out.println(Math.abs(stopTime-startTime)/10000);
			
			System.out.println(">> Increasing Integers");
			for (int i = 0; i < arr.length; i++) {
				arr[i] = increasingArray[i];
			}
			
			temp = arr[(int)((arr.length-1)/2)];
			arr[(int)((arr.length-1)/2)] = arr[arr.length-1];
			arr[arr.length-1] = temp;
			startTime = (int) System.nanoTime();
			quickSort(arr,0,arr.length-1);
			stopTime = (int) System.nanoTime();
			System.out.println(Math.abs(stopTime-startTime)/10000);
			
			System.out.println(">> Decreasing Integers");
			for (int i = 0; i < arr.length; i++) {
				arr[i] = decreasingArray[i];
			}
			
			temp = arr[(int)((arr.length-1)/2)];
			arr[(int)((arr.length-1)/2)] = arr[arr.length-1];
			arr[arr.length-1] = temp;
			startTime = (int) System.nanoTime();
			quickSort(arr,0,arr.length-1);
			stopTime = (int) System.nanoTime();
			System.out.println(Math.abs(stopTime-startTime)/10000);
			
			System.out.println("\n"+"---------- Quick Sort Random Element ----------");
			System.out.println(">> Equal Integers");
			for (int i = 0; i < arr.length; i++) {
				arr[i] = constantArray[i];
			}
			startTime = (int) System.nanoTime();
			int randomIndex =(int) (Math.random()*arraySizes-1);
			quickSort(arr,0,randomIndex);
			stopTime = (int) System.nanoTime();
			System.out.println(Math.abs(stopTime-startTime)/10000);
			
			System.out.println(">> Random Integers");
			for (int i = 0; i < arr.length; i++) {
				arr[i] = randomArray[i];
			}
			startTime = (int) System.nanoTime();
			quickSort(arr,0,randomIndex);
			stopTime = (int) System.nanoTime();
			System.out.println(Math.abs(stopTime-startTime)/10000);
			
			System.out.println(">> Increasing Integers");
			for (int i = 0; i < arr.length; i++) {
				arr[i] = increasingArray[i];
			}
			startTime = (int) System.nanoTime();
			quickSort(arr,0,randomIndex);
			stopTime = (int) System.nanoTime();
			System.out.println(Math.abs(stopTime-startTime)/10000);
			
			System.out.println(">> Decreasing Integers");
			for (int i = 0; i < arr.length; i++) {
				arr[i] = decreasingArray[i];
			}
			startTime = (int) System.nanoTime();
			quickSort(arr,0,randomIndex);
			stopTime = (int) System.nanoTime();
			System.out.println(Math.abs(stopTime-startTime)/10000);
			
			System.out.println("\n"+"---------- Heap Sort ----------");
			
			System.out.println(">> Equal Integers");
			for (int i = 0; i < arr.length; i++) {
				arr[i] = constantArray[i];
			}
			startTime = (int) System.nanoTime();
			heapSort(arr);
			stopTime = (int) System.nanoTime();
			System.out.println(Math.abs(stopTime-startTime)/10000);
			
			System.out.println(">> Random Integers");
			for (int i = 0; i < arr.length; i++) {
				arr[i] = randomArray[i];
			}
			startTime = (int) System.nanoTime();
			heapSort(arr);
			stopTime = (int) System.nanoTime();
			System.out.println(Math.abs(stopTime-startTime)/10000);
			
			System.out.println(">> Increasing Integers");
			for (int i = 0; i < arr.length; i++) {
				arr[i] = increasingArray[i];
			}
			startTime = (int) System.nanoTime();
			heapSort(arr);
			stopTime = (int) System.nanoTime();
			System.out.println(Math.abs(stopTime-startTime)/10000);
			
			System.out.println(">> decreasing Integers");
			for (int i = 0; i < arr.length; i++) {
				arr[i] = decreasingArray[i];
			}
			startTime = (int) System.nanoTime();
			heapSort(arr);
			stopTime = (int) System.nanoTime();
			System.out.println(Math.abs(stopTime-startTime)/10000);
			
			System.out.println("\n"+"---------- Merge Sort ----------");
			System.out.println(">> Equal Integers");
			for (int i = 0; i < arr.length; i++) {
				arr[i] = constantArray[i];
			}
			startTime = (int) System.nanoTime();
			mergeSort(arr);
			stopTime = (int) System.nanoTime();
			System.out.println(Math.abs(stopTime-startTime)/10000);
			
			System.out.println(">> Random Integers");
			for (int i = 0; i < arr.length; i++) {
				arr[i] = randomArray[i];
			}
			startTime = (int) System.nanoTime();
			mergeSort(arr);
			stopTime = (int) System.nanoTime();
			System.out.println(Math.abs(stopTime-startTime)/10000);
			
			System.out.println(">> Increasing Integers");
			for (int i = 0; i < arr.length; i++) {
				arr[i] = increasingArray[i];
			}
			startTime = (int) System.nanoTime();
			mergeSort(arr);
			stopTime = (int) System.nanoTime();
			System.out.println(Math.abs(stopTime-startTime)/10000);
			
			System.out.println(">> Decreasing Integers");
			for (int i = 0; i < arr.length; i++) {
				arr[i] = decreasingArray[i];
			}
			startTime = (int) System.nanoTime();
			mergeSort(arr);
			stopTime = (int) System.nanoTime();
			System.out.println(Math.abs(stopTime-startTime)/10000);
			
			System.out.println("\n"+"---------- Merge Sort 3 Part ----------");
			
			System.out.println(">> Equal Integers");
			for (int i = 0; i < arr.length; i++) {
				arr[i] = constantArray[i];
			}
			startTime = (int) System.nanoTime();
			mergeSort3Way(arr);
			stopTime = (int) System.nanoTime();
			System.out.println(Math.abs(stopTime-startTime)/10000);
			
			System.out.println(">> Random Integers");
			for (int i = 0; i < arr.length; i++) {
				arr[i] = randomArray[i];
			}
			startTime = (int) System.nanoTime();
			mergeSort3Way(arr);
			stopTime = (int) System.nanoTime();
			System.out.println(Math.abs(stopTime-startTime)/10000);
			
			System.out.println(">> Increasing Integers");
			for (int i = 0; i < arr.length; i++) {
				arr[i] = increasingArray[i];
			}
			startTime = (int) System.nanoTime();
			mergeSort3Way(arr);
			stopTime = (int) System.nanoTime();
			System.out.println(Math.abs(stopTime-startTime)/10000);
			
			System.out.println(">> Decreasing Integers");
			for (int i = 0; i < arr.length; i++) {
				arr[i] = decreasingArray[i];
			}
			startTime = (int) System.nanoTime();
			mergeSort3Way(arr);
			stopTime = (int) System.nanoTime();
			System.out.println(Math.abs(stopTime-startTime)/10000);
			arraySizes*=10;
			startTime=0;
			stopTime=0;
		}
		
	}
	
	
	// Heap size N
	private static int N;
	
	//Heap Sort---------
    public static void heapSort(int arr[]){
        heapify(arr);        
        for (int i = N; i > 0; i--){
            exchange(arr,0, i);
            N = N-1;
            maxHeap(arr, 0);
        }
    }   
    public static void heapify(int arr[]){
        N = arr.length-1;
        for (int i = N/2; i >= 0; i--){
            maxHeap(arr, i);
        }
    }        
    public static void maxHeap(int arr[], int i){ 
        int left = 2*i ;
        int right = 2*i + 1;
        int max = i;
        if (left <= N && arr[left] > arr[i]){
            max = left;
        }
        if (right <= N && arr[right] > arr[max]){        
            max = right;
        }
        if (max != i){
            exchange(arr, i, max);
            maxHeap(arr, max);
        }
    }
    // -----------------
    
    // Exchange tool----
    public static void exchange(int arr[], int i, int j){
        int tmp = arr[i];
        arr[i] = arr[j];
        arr[j] = tmp; 
    } 
    // -----------------

    // Quick Sort------
    static int partition(int arr[], int low, int high){
        int pivot = arr[high];
        int i = (low-1);
        for (int j=low; j<high; j++){
            if (arr[j] <= pivot){
                i++;
                int temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
            }
        }
        int temp = arr[i+1];
        arr[i+1] = arr[high];
        arr[high] = temp;
 
        return i+1;
    }
    static void quickSort(int arr[], int low, int high){
        if (low < high){
            int pivot = partition(arr, low, high);
            //quickSort(arr, low, pivot-1);
            quickSort(arr, pivot+1, high);
        }
    }
    // ----------------

    // Merge Sort------
    public static void mergeSort(int inputArr[]) {
        array = inputArr;
        length = inputArr.length;
        tempMergArr = new int[length];
        doMergeSort(0, length - 1);
    }
    private static void doMergeSort(int lowerIndex, int higherIndex) {
         
        if (lowerIndex < higherIndex) {
            int middle = lowerIndex + (higherIndex - lowerIndex) / 2;
            doMergeSort(lowerIndex, middle);
            doMergeSort(middle + 1, higherIndex);
            mergeParts(lowerIndex, middle, higherIndex);
        }
    }
    private static void mergeParts(int lowerIndex, int middle, int higherIndex) {
        for (int i = lowerIndex; i <= higherIndex; i++) {
            tempMergArr[i] = array[i];
        }
        int i = lowerIndex;
        int j = middle + 1;
        int k = lowerIndex;
        while (i <= middle && j <= higherIndex) {
            if (tempMergArr[i] <= tempMergArr[j]) {
                array[k] = tempMergArr[i];
                i++;
            } else {
                array[k] = tempMergArr[j];
                j++;
            }
            k++;
        }
        while (i <= middle) {
            array[k] = tempMergArr[i];
            k++;
            i++;
        }
 
    }
    // ----------------

    // 3 Part Merge Sort
    public static void mergeSort3Way(int[] givenArray) {
        if (givenArray == null){
            return;
        }
        int[] fArray = new int[givenArray.length];
        for (int i = 0; i < fArray.length; i++){
            fArray[i] = givenArray[i];
        }
        mergeSort3Part(fArray, 0, givenArray.length, givenArray);
        for (int i = 0; i < fArray.length; i++){
            givenArray[i] = fArray[i];
        }
    }
    public static void mergeSort3Part(int[] givenArray, int low, int high, int[] destArray){
        if (high - low < 2){
            return;
        }
        int mid1 = low + ((high - low) / 3);
        int mid2 = low + 2 * ((high - low) / 3) + 1;
        mergeSort3Part(destArray, low, mid1, givenArray);
        mergeSort3Part(destArray, mid1, mid2, givenArray);
        mergeSort3Part(destArray, mid2, high, givenArray);
        merge(destArray, low, mid1, mid2, high, givenArray);
    }
    public static void merge(int[] givenArray, int low,int mid1, int mid2, int high,int[] destArray){
        int i = low, j = mid1, k = mid2, l = low;
        while ((i < mid1) && (j < mid2) && (k < high)){
            if (givenArray[i]< givenArray[j]){
                if (givenArray[i]<givenArray[k]){
                    destArray[l++] = givenArray[i++];
                }
                else{
                    destArray[l++] = givenArray[k++];
                }
            }
            else{
                if (givenArray[j]<givenArray[k]){
                    destArray[l++] = givenArray[j++];
                }
                else{
                    destArray[l++] = givenArray[k++];
                }
            }
        }
        while ((i < mid1) && (j < mid2)){
            if (givenArray[i]<givenArray[j]){
                destArray[l++] = givenArray[i++];
            }
            else{
                destArray[l++] = givenArray[j++];
            }
        }
        while ((j < mid2) && (k < high)){
            if (givenArray[j]<givenArray[k]){
                destArray[l++] = givenArray[j++];
            }
            else{
                destArray[l++] = givenArray[k++];
            }
        }
        while ((i < mid1) && (k < high)){
            if (givenArray[i]<givenArray[k] ){
                destArray[l++] = givenArray[i++];
            }
            else{
                destArray[l++] = givenArray[k++];
            }
        }
        while (i < mid1){
            destArray[l++] = givenArray[i++];
        }
        while (j < mid2){
            destArray[l++] = givenArray[j++];
        }
        while (k < high){
            destArray[l++] = givenArray[k++];
        }
    }
    // -----------------
}
