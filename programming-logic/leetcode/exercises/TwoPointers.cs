using System;
using System.Collections.Generic;

namespace LeetCodeExercises
{
    public class TwoSumSolution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            // 1. Programação Defensiva: Validação inicial para garantir que o array é válido
            if (nums == null || nums.Length < 2)
            {
                throw new ArgumentException("O array deve conter pelo menos dois elementos.", nameof(nums));
            }

            // 2. Criamos um Dicionário (Hash Map) para armazenar:
            // - Chave (Key): O número do array (`nums[i]`)
            // - Valor (Value): O índice onde esse número está localizado (`i`)
            // Objetivo: Buscar valores em O(1) (tempo constante) em vez de varrer o array de novo.
            Dictionary<int, int> numIndices = new Dictionary<int, int>();

            // 3. Percorremos o array uma única vez (Complexidade de Tempo: O(N))
            for (int i = 0; i < nums.Length; i++)
            {
                int currentNumber = nums[i];

                // O complemento é o valor que, somado ao número atual, resulta no target.
                // Exemplo: se target = 9 e currentNumber = 2, o complemento que precisamos é 7.
                int complement = target - currentNumber;

                // 4. Verificamos se o complemento já foi visitado antes e está guardado no Dicionário.
                if (numIndices.ContainsKey(complement))
                {
                    // Se encontramos o complemento, significa que já passamos por ele antes!
                    // Retornamos um novo array contendo: [índice do complemento, índice atual]
                    return new int[] { numIndices[complement], i };
                }

                // 5. Se o complemento ainda não foi encontrado, salvamos o número atual e seu índice 
                // no dicionário para consultas futuras, garantindo que não duplicamos chaves.
                if (!numIndices.ContainsKey(currentNumber))
                {
                    numIndices.Add(currentNumber, i);
                }
            }

            // 6. Caso de segurança (embora o problema garanta que sempre há uma solução)
            throw new InvalidOperationException("Nenhuma solução válida foi encontrada.");
        }
    }
}