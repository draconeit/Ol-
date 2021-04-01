df = pd.read_csv(""https://drive.google.com/file/d/1Enl5hjoU7tN4T38pWvZaw9_80whYGE39/view?usp=sharing"")

df = df.groupby(['State', 'ANSI', 'Affected by', 'Year', 'state_code'])[['Pct of Colonies Impacted']].mean()
df.reset_index(inplace=True)
print(df[:5])
