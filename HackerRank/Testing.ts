process.stdin.resume();
process.stdin.setEncoding("utf-8");

let inputString: string = "";
let inputLines: string[] = [];
let currentLine: number = 0;

process.stdin.on("data", function (inputStdin: string): void {
  inputString += inputStdin;
});

process.stdin.on("end", function (): void {
  inputLines = inputString.split("\n");
  inputString = "";

  main();
});

function readLine(): string {
  return inputLines[currentLine++];
}

function main(): void {
  const t: number = parseInt(readLine().trim(), 10);
  const testData: number[][] = [[], [7, 3, 9, 2], [5, 8, 1, 4, 1, 2]];
  console.log(inputString);
  for (let tItr: number = 0; tItr < t; tItr++) {
    const firstMultipleInput: string[] = readLine()
      .replace(/\s+$/g, "")
      .split(" ");

    const n: number = parseInt(firstMultipleInput[0], 10);

    const k: number = parseInt(firstMultipleInput[1], 10);

    const a: number[] = (readLine() ?? "")
      .replace(/\s+$/g, "")
      .split(" ")
      .map((aTemp) => parseInt(aTemp, 10));

    testData.push(a);
  }
  TestWithEmptyArray(testData[0]);
  TestWithUniqueValues(testData[1]);
  TestWithExactlyTwoDifferentMinimums(testData[2]);
  console.log("OK");
}

function len(seq: number[]): number {
  return seq.length;
}

function minimum_index(seq: number[]): number {
  if (len(seq) === 0)
    throw new Error(
      "Cannot get the minimum value index from an empty sequence"
    );
  let minIndex = 0;
  for (let i = 0; i < seq.length; i++) {
    if (seq[i] < seq[minIndex]) {
      minIndex = i;
    }
  }
  return minIndex;
}

const TestWithEmptyArray = (seq: number[]): void => {
  try {
    minimum_index(seq);
  } catch (error: any) {
    console.assert(error instanceof Error);
  }
};

const TestWithUniqueValues = (seq: number[]): void => {
  console.assert(seq.length >= 2);
  console.assert(new Set(seq).size === seq.length);
  const expected_result: number = 3;
  const result = minimum_index(seq);
  console.assert(result === expected_result);
};

const TestWithExactlyTwoDifferentMinimums = (seq: number[]): void => {
  console.assert(seq.length >= 2);
  const sorted = seq.slice().sort();
  console.assert(
    sorted[0] == sorted[1] && (sorted.length == 2 || sorted[1] < sorted[2])
  );
  const expected_result: number = 2;
  const result = minimum_index(seq);
  console.assert(result === expected_result);
};
