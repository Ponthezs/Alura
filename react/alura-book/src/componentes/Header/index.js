import './estilo.css'
import './estilo.css'
import Logo from '../Logo'
import OpcoesHeader from '../OpcoesHeader'
import IconesHeader from '../IconesHeader'

function Header() {
    return(
        <header className='App-header'>
            <Logo/>
            <OpcoesHeader/>
            <IconesHeader/>
        </header>
    )
}

export default Header