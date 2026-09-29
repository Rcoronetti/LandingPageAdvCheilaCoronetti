# Cheila Coronetti — Landing Page

Site institucional da Dra. Cheila Coronetti — Direito Previdenciário.
Stack: Blazor Web App (.NET 10) com SSR puro, CSS customizado e JavaScript vanilla.

## Como executar
dotnet restore
dotnet run --project src/CheilaCoronetti.Web

## Deploy

Deploy automático via GitHub Actions: a cada push na `main`, o workflow
`.github/workflows/deploy.yml` compila o projeto em Release, copia os arquivos
para o VPS via SSH/SCP e reinicia o serviço do site.

| Item | Valor |
| --- | --- |
| Hospedagem | VPS Locaweb — Ubuntu 24.04 LTS (vps71616.publiccloud.com.br) |
| Runtime | ASP.NET Core 10.0 |
| Proxy reverso | Caddy (porta 80 → localhost:5000) |
| Serviço | systemd `cheila.service` — arquivos em `/var/www/cheila` |
| Endereço atual | http://177.153.67.175 |
| Domínio | cheilacoronetti.adv.br (Registro.br — aguardando compensação do boleto) |

**Secrets necessários** (Settings → Secrets and variables → Actions):

- `VPS_HOST` — IP do VPS
- `VPS_USER` — usuário SSH (`root`)
- `VPS_SSH_KEY` — chave privada ed25519 do par de deploy

**Publicar manualmente:** GitHub → Actions → "Deploy para VPS" → Run workflow.

> Documentação completa de infraestrutura, manutenção e disaster recovery:
> documento "Site Cheila Coronetti — Documentação de Infraestrutura e Manutenção" (set/2026).

## Pendências antes do lançamento
| Item | Onde | Status |
| --- | --- | --- |
| Avaliações reais do Google | Data/AvaliacoesRepository.cs | pendente |
| Bios da equipe (substituir Lorem ipsum) | Data/Equipe.cs | pendente |
| N.º OAB | Rodape.razor / Equipe.cs | pendente |
| Horário de atendimento | Contato.razor | pendente |
| URL do domínio | App.razor (JSON-LD) | pendente |
| Fotos reais (advogada e equipe) | wwwroot/img/ | pendente |
| Imagem Open Graph | wwwroot/img/og-image.png | pendente |
| DNS do domínio + HTTPS | Registro.br / Caddyfile | aguardando boleto |

## Licença
© 2026 Rafael Coronetti. Todos os direitos reservados. Proibida a reprodução sem autorização.
