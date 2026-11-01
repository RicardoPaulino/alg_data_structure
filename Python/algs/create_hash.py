import hashlib

texto_original = "SenhaSecreta123"

# 1. Codifica a string para bytes e aplica o algoritmo SHA-256
objeto_hash = hashlib.sha256(texto_original.encode('utf-8'))

# 2. Extrai o resultado em formato hexadecimal legível
hash_hex = objeto_hash.hexdigest()

print(f"Texto original: {texto_original}")
print(f"Hash SHA-256 (Python): {hash_hex}")