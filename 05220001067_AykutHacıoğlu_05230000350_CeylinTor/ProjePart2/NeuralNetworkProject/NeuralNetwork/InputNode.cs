using System;

namespace NeuralNetworkProject.CustomNetwork
{
    public class InputNode
    {
        public double[] InputValues { get; private set; }

        public InputNode(int nodeCount)
        {
            InputValues = new double[nodeCount];
        }

        public void AssignInputMatrix(int[,] inputMatrix)
        {
            int flatIndex = 0;
            for (int row = 0; row < inputMatrix.GetLength(0); row++)
            {
                for (int col = 0; col < inputMatrix.GetLength(1); col++)
                {
                    InputValues[flatIndex] = inputMatrix[row, col];
                    flatIndex++;
                }
            }
        }
    }
}
